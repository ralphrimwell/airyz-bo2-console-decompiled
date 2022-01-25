using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using Airyz;
using BO2_Console_V4.Classes;
using Microsoft.Toolkit.Win32.UI.Controls.WPF;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ScreenRecorderLib;

namespace BO2_Console_V4
{
	// Token: 0x02000032 RID: 50
	public class DemoMetadataEditor : Window, IComponentConnector
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0002FE2C File Offset: 0x0002E02C
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0002FE34 File Offset: 0x0002E034
		public Dictionary<string, string> metadata { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0002FE3D File Offset: 0x0002E03D
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0002FE45 File Offset: 0x0002E045
		public string demo_title { get; set; }

		// Token: 0x06000064 RID: 100 RVA: 0x0002FE4E File Offset: 0x0002E04E
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[DemoMetadataEditor.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0002FE8C File Offset: 0x0002E08C
		public DemoMetadataEditor(string demoFilePath, Dictionary<string, string> currentMetadata, Addresses _addresses, AiryzMemory memory, ExternalConsole _console, string[] _streamable_credentials)
		{
			this.InitializeComponent();
			this.demo_title = new DirectoryInfo(Path.GetDirectoryName(demoFilePath)).Name;
			this.TitleTextBox.Text = this.demo_title;
			this.addresses = _addresses;
			this.BO2 = memory;
			this.console = _console;
			this.demo_file_path = demoFilePath;
			this.streamable_credentials = _streamable_credentials;
			currentMetadata.TryGetValue("video_id", out this.videoID);
			currentMetadata.TryGetValue("embed_host", out this.host);
			string text = this.host;
			if (text != null)
			{
				if (!(text == "yt"))
				{
					if (text == "streamable")
					{
						this.video_url = "https://www.streamable.com/" + this.videoID;
					}
				}
				else
				{
					this.video_url = "https://www.youtube.com/watch?v=" + this.videoID;
				}
			}
			Console.WriteLine("VideoID: " + this.videoID);
			string text2;
			if (currentMetadata.TryGetValue("start_time", out text2))
			{
				this.startTime = int.Parse(text2);
				this.StartTimeTextbox.Text = text2;
			}
			if (currentMetadata.TryGetValue("end_time", out text2))
			{
				this.endTime = int.Parse(text2);
				this.EndTimeTextbox.Text = text2;
			}
			if (currentMetadata.TryGetValue("description", out text2))
			{
				this.DescriptionTextbox.Text = text2;
			}
			if (currentMetadata.TryGetValue("author", out text2))
			{
				this.AuthorTextBox.Text = text2;
			}
			if (currentMetadata.TryGetValue("start_tick", out text2))
			{
				this.StartTickTextBox.Text = text2;
			}
			if (currentMetadata.TryGetValue("player_index", out text2))
			{
				this.PlayerIndexBox.Text = text2;
			}
			SolidColorBrush solidColorBrush = (SolidColorBrush)base.Resources["DefaultBackground"];
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00030050 File Offset: 0x0002E250
		private void CreateRecording()
		{
			this.videoPath = Path.Combine(Path.GetTempPath(), DemoMetadataEditor.RandomString(10) + ".mp4");
			Console.WriteLine(this.videoPath);
			this._outStream = new MemoryStream();
			RecorderOptions recorderOptions = new RecorderOptions
			{
				DisplayOptions = new DisplayOptions
				{
					WindowHandle = this.BO2.winHandle
				},
				RecorderApi = 1
			};
			this._rec = Recorder.CreateRecorder(recorderOptions);
			this._rec.Record(this.videoPath);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000300DA File Offset: 0x0002E2DA
		private void CancelButton_Click(object sender, RoutedEventArgs e)
		{
			this.demoPreviewerWebView.Close();
			this.demoPreviewerWebView.Dispose();
			base.DialogResult = new bool?(false);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00030100 File Offset: 0x0002E300
		private void FinishedButton_Click(object sender, RoutedEventArgs e)
		{
			this.metadata = new Dictionary<string, string>();
			this.metadata.Add("has_embed", this.hasEmbed.ToString());
			if (this.hasEmbed == 1)
			{
				this.metadata.Add("embed_host", this.host);
				this.metadata.Add("video_id", this.videoID);
				string text = this.host;
				if (text != null)
				{
					if (!(text == "yt"))
					{
						if (!(text == "streamable"))
						{
						}
					}
					else
					{
						this.metadata.Add("start_time", this.startTime.ToString());
						this.metadata.Add("end_time", this.endTime.ToString());
					}
				}
			}
			if (this.DescriptionTextbox.Text.Length > 0)
			{
				this.metadata.Add("description", this.DescriptionTextbox.Text);
			}
			if (this.AuthorTextBox.Text.Length > 0)
			{
				this.metadata.Add("author", this.AuthorTextBox.Text);
			}
			if (this.StartTickTextBox.Text.Length > 0)
			{
				this.metadata.Add("start_tick", this.StartTickTextBox.Text);
			}
			if (this.PlayerIndexBox.Text.Length > 0)
			{
				this.metadata.Add("player_index", this.PlayerIndexBox.Text);
			}
			this.demoPreviewerWebView.Close();
			this.demoPreviewerWebView.Dispose();
			this.demo_title = this.TitleTextBox.Text;
			base.DialogResult = new bool?(true);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000302B2 File Offset: 0x0002E4B2
		private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000302B2 File Offset: 0x0002E4B2
		private void Window_Initialized(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000302B4 File Offset: 0x0002E4B4
		private void URLTextbox_TextChanged(object sender, TextChangedEventArgs e)
		{
			this.ParseURL(this.URLTextbox.Text);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000302C7 File Offset: 0x0002E4C7
		private int HourToSeconds(int Hour)
		{
			return Hour * 3600;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000302D0 File Offset: 0x0002E4D0
		private int MinToSeconds(int Min)
		{
			return Min * 60;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000302D8 File Offset: 0x0002E4D8
		private int ParseTime(string text)
		{
			int result;
			try
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				string[] array = text.Split(new char[]
				{
					':'
				});
				result = text.Count((char x) => x == ':');
				switch (result)
				{
				case 0:
					num = int.Parse(text);
					break;
				case 1:
					num2 = int.Parse(array[0]);
					num = int.Parse(array[1]);
					break;
				case 2:
					num3 = int.Parse(array[0]);
					num2 = int.Parse(array[1]);
					num = int.Parse(array[2]);
					break;
				}
				if (num >= 0 || num2 >= 0 || num3 >= 0)
				{
					result = num + this.MinToSeconds(num2) + this.HourToSeconds(num3);
				}
				else
				{
					result = -1;
				}
			}
			catch
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000303B0 File Offset: 0x0002E5B0
		private void ParseURL(string URL)
		{
			if (URL.Contains("youtube.com"))
			{
				try
				{
					this.videoID = URL.Split(new string[]
					{
						"?v="
					}, StringSplitOptions.None)[1];
					if (this.videoID.Contains('&'))
					{
						this.videoID = this.videoID.Split(new char[]
						{
							'&'
						})[0];
					}
					if (URL.Contains("ab_channel="))
					{
						string text = URL.Split(new string[]
						{
							"ab_channel="
						}, StringSplitOptions.None)[1];
						if (text.Contains('&'))
						{
							text = text.Split(new char[]
							{
								'&'
							})[0];
						}
						this.AuthorTextBox.Text = text;
					}
					this.demoPreviewerWebView.Navigate(EmbedURLBuilder.Youtube(this.videoID, true, 0, 0, false));
					this.StartEndTimeChangerGrid.Visibility = Visibility.Visible;
					this.host = "yt";
					this.hasEmbed = 1;
					return;
				}
				catch
				{
					this.hasEmbed = 0;
					return;
				}
			}
			if (URL.Contains("youtu.be"))
			{
				try
				{
					this.host = "yt";
					this.StartEndTimeChangerGrid.Visibility = Visibility.Visible;
					this.hasEmbed = 1;
					return;
				}
				catch
				{
					this.hasEmbed = 0;
					return;
				}
			}
			if (URL.Contains("streamable"))
			{
				try
				{
					this.videoID = URL.Split(new string[]
					{
						".com/"
					}, StringSplitOptions.None)[1];
					if (this.videoID.Contains("?"))
					{
						this.videoID = this.videoID.Split(new char[]
						{
							'?'
						})[0];
					}
					SolidColorBrush col = (SolidColorBrush)base.Resources["DefaultBackground"];
					this.demoPreviewerWebView.NavigateToString(EmbedURLBuilder.Streamable(this.videoID, col, (int)this.demoPreviewerWebView.Width, (int)this.demoPreviewerWebView.Height, true, true));
					this.host = "streamable";
					this.StartEndTimeChangerGrid.Visibility = Visibility.Hidden;
					this.hasEmbed = 1;
					return;
				}
				catch
				{
					this.hasEmbed = 0;
					return;
				}
			}
			this.StartEndTimeChangerGrid.Visibility = Visibility.Hidden;
			this.hasEmbed = 0;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000305F8 File Offset: 0x0002E7F8
		private void StartTimeTextbox_TextChanged(object sender, TextChangedEventArgs e)
		{
			this.startTime = this.ParseTime(this.StartTimeTextbox.Text);
			if (this.videoID.Length > 1)
			{
				string text = this.host;
				if (text != null && text == "yt")
				{
					this.demoPreviewerWebView.Navigate(EmbedURLBuilder.Youtube(this.videoID, true, this.startTime, this.endTime, false));
				}
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00030668 File Offset: 0x0002E868
		private void EndTimeTextbox_TextChanged(object sender, TextChangedEventArgs e)
		{
			this.endTime = this.ParseTime(this.EndTimeTextbox.Text);
			if (this.videoID.Length > 1)
			{
				string text = this.host;
				if (text != null && text == "yt")
				{
					this.demoPreviewerWebView.Navigate(EmbedURLBuilder.Youtube(this.videoID, true, this.startTime, this.endTime, false));
				}
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000306D8 File Offset: 0x0002E8D8
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.StartTickTextBox.Text = this.BO2.ReadInt(this.addresses.Tick).ToString();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00030710 File Offset: 0x0002E910
		private void ReadCurrentPlayer_Click(object sender, RoutedEventArgs e)
		{
			this.PlayerIndexBox.Text = this.BO2.ReadInt(this.addresses.selectedPlayerIndex).ToString();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00030748 File Offset: 0x0002E948
		private void RecordNewClipButton_Click(object sender, RoutedEventArgs e)
		{
			this.CreateRecording();
			this.ReadCurrentPlayer_Click(null, null);
			this.Button_Click(null, null);
			this.RecordNewClipButton.Content = "Recording...";
			this.CancelRecordingButton.IsEnabled = true;
			this.SaveAndUploadButton.IsEnabled = true;
			this.RecordNewClipButton.IsEnabled = false;
			Task.Run(delegate()
			{
				Thread.Sleep(500);
				this.console.Send("demo_pause 0");
			});
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000307B4 File Offset: 0x0002E9B4
		private void CancelRecordingButton_Click(object sender, RoutedEventArgs e)
		{
			this._rec.Stop();
			this._rec.Dispose();
			this.RecordNewClipButton.Content = "Record New Clip";
			this.CancelRecordingButton.IsEnabled = false;
			this.SaveAndUploadButton.IsEnabled = false;
			this.RecordNewClipButton.IsEnabled = true;
			File.Delete(this.videoPath);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00030818 File Offset: 0x0002EA18
		public bool callbackTest(string input)
		{
			Console.WriteLine("Here from callbackK swagasda! " + input);
			JToken result = JsonConvert.DeserializeObject<JToken>(input);
			this.URLTextbox.Dispatcher.Invoke(delegate()
			{
				TextBox urltextbox = this.URLTextbox;
				string str = "https://www.streamable.com/";
				JToken jtoken = result["shortcode"];
				urltextbox.Text = str + ((jtoken != null) ? jtoken.ToString() : null);
				this.SaveAndUploadButton.Content = "Save and Upload";
				this.RecordNewClipButton.IsEnabled = true;
			});
			return true;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0003086C File Offset: 0x0002EA6C
		private void SaveAndUploadButton_Click(object sender, RoutedEventArgs e)
		{
			this.RecordNewClipButton.Content = "Record New Clip";
			this.CancelRecordingButton.IsEnabled = false;
			this.SaveAndUploadButton.IsEnabled = false;
			this.RecordNewClipButton.IsEnabled = false;
			this.SaveAndUploadButton.Content = "Uploading...";
			this._rec.Stop();
			this._rec.Dispose();
			this.console.Send("demo_pause 1");
			byte[] data = File.ReadAllBytes(this.videoPath);
			if (this.streamable_credentials.Length != 2)
			{
				this.SaveAndUploadButton.Content = "Error: No Streamable Account Connected";
				File.Delete(this.videoPath);
				return;
			}
			StreamableAPI.UploadVideo(this.streamable_credentials[0], this.streamable_credentials[1], data, Path.GetFileNameWithoutExtension(this.demo_file_path), new Func<string, bool>(this.callbackTest));
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00030943 File Offset: 0x0002EB43
		private void demoPreviewerWebView_Loaded(object sender, RoutedEventArgs e)
		{
			Console.WriteLine("SWASGGGG");
			this.URLTextbox.Text = this.video_url;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00030960 File Offset: 0x0002EB60
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/BO2 Console V4;component/xaml/demometadataeditor.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00030990 File Offset: 0x0002EB90
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.MainGrid = (Grid)target;
				return;
			case 2:
				this.ApplicationScaleTransform = (ScaleTransform)target;
				return;
			case 3:
				this.CancelButton = (Button)target;
				this.CancelButton.Click += this.CancelButton_Click;
				return;
			case 4:
				this.FinishedButton = (Button)target;
				this.FinishedButton.Click += this.FinishedButton_Click;
				return;
			case 5:
				this.Tabs = (TabControl)target;
				this.Tabs.SelectionChanged += this.TabControl_SelectionChanged;
				return;
			case 6:
				this.URLTextbox = (TextBox)target;
				this.URLTextbox.TextChanged += this.URLTextbox_TextChanged;
				return;
			case 7:
				this.demoPreviewerWebView = (WebView)target;
				this.demoPreviewerWebView.Loaded += this.demoPreviewerWebView_Loaded;
				return;
			case 8:
				this.StartEndTimeChangerGrid = (Grid)target;
				return;
			case 9:
				this.StartTimeTextbox = (TextBox)target;
				this.StartTimeTextbox.TextChanged += this.StartTimeTextbox_TextChanged;
				return;
			case 10:
				this.EndTimeTextbox = (TextBox)target;
				this.EndTimeTextbox.TextChanged += this.EndTimeTextbox_TextChanged;
				return;
			case 11:
				this.RecordNewClipButton = (Button)target;
				this.RecordNewClipButton.Click += this.RecordNewClipButton_Click;
				return;
			case 12:
				this.CancelRecordingButton = (Button)target;
				this.CancelRecordingButton.Click += this.CancelRecordingButton_Click;
				return;
			case 13:
				this.SaveAndUploadButton = (Button)target;
				this.SaveAndUploadButton.Click += this.SaveAndUploadButton_Click;
				return;
			case 14:
				this.AuthorTextBox = (TextBox)target;
				return;
			case 15:
				this.DescriptionTextbox = (TextBox)target;
				return;
			case 16:
				this.PlayerIndexBox = (TextBox)target;
				return;
			case 17:
				((Button)target).Click += this.ReadCurrentPlayer_Click;
				return;
			case 18:
				this.StartTickTextBox = (TextBox)target;
				return;
			case 19:
				((Button)target).Click += this.Button_Click;
				return;
			case 20:
				this.TitleTextBox = (TextBox)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x0400014F RID: 335
		private string videoID;

		// Token: 0x04000150 RID: 336
		private int startTime;

		// Token: 0x04000151 RID: 337
		private int endTime;

		// Token: 0x04000152 RID: 338
		private int hasEmbed;

		// Token: 0x04000153 RID: 339
		private string host;

		// Token: 0x04000154 RID: 340
		private Addresses addresses;

		// Token: 0x04000155 RID: 341
		private AiryzMemory BO2;

		// Token: 0x04000156 RID: 342
		private ExternalConsole console;

		// Token: 0x04000157 RID: 343
		private Recorder _rec;

		// Token: 0x04000158 RID: 344
		private MemoryStream _outStream;

		// Token: 0x04000159 RID: 345
		private string videoPath;

		// Token: 0x0400015A RID: 346
		private string demo_file_path;

		// Token: 0x0400015B RID: 347
		private string[] streamable_credentials;

		// Token: 0x0400015C RID: 348
		private string video_url;

		// Token: 0x0400015D RID: 349
		private static Random random = new Random();

		// Token: 0x0400015E RID: 350
		internal Grid MainGrid;

		// Token: 0x0400015F RID: 351
		internal ScaleTransform ApplicationScaleTransform;

		// Token: 0x04000160 RID: 352
		internal Button CancelButton;

		// Token: 0x04000161 RID: 353
		internal Button FinishedButton;

		// Token: 0x04000162 RID: 354
		internal TabControl Tabs;

		// Token: 0x04000163 RID: 355
		internal TextBox URLTextbox;

		// Token: 0x04000164 RID: 356
		internal WebView demoPreviewerWebView;

		// Token: 0x04000165 RID: 357
		internal Grid StartEndTimeChangerGrid;

		// Token: 0x04000166 RID: 358
		internal TextBox StartTimeTextbox;

		// Token: 0x04000167 RID: 359
		internal TextBox EndTimeTextbox;

		// Token: 0x04000168 RID: 360
		internal Button RecordNewClipButton;

		// Token: 0x04000169 RID: 361
		internal Button CancelRecordingButton;

		// Token: 0x0400016A RID: 362
		internal Button SaveAndUploadButton;

		// Token: 0x0400016B RID: 363
		internal TextBox AuthorTextBox;

		// Token: 0x0400016C RID: 364
		internal TextBox DescriptionTextbox;

		// Token: 0x0400016D RID: 365
		internal TextBox PlayerIndexBox;

		// Token: 0x0400016E RID: 366
		internal TextBox StartTickTextBox;

		// Token: 0x0400016F RID: 367
		internal TextBox TitleTextBox;

		// Token: 0x04000170 RID: 368
		private bool _contentLoaded;
	}
}
