using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Airyz;
using BO2PluginFramework;
using BO2_Console_V4.Classes;

namespace BO2_Console_V4
{
	// Token: 0x02000035 RID: 53
	public class CustomSliderDialog : Window, IComponentConnector
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00030CBD File Offset: 0x0002EEBD
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00030CC5 File Offset: 0x0002EEC5
		public string dvarName { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00030CCE File Offset: 0x0002EECE
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00030CD6 File Offset: 0x0002EED6
		public dvarType_t dvarType { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00030CDF File Offset: 0x0002EEDF
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00030CE7 File Offset: 0x0002EEE7
		public object dvarMin { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00030CF0 File Offset: 0x0002EEF0
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00030CF8 File Offset: 0x0002EEF8
		public object dvarMax { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00030D01 File Offset: 0x0002EF01
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00030D09 File Offset: 0x0002EF09
		public object dvarCurrent { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00030D12 File Offset: 0x0002EF12
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00030D1A File Offset: 0x0002EF1A
		public IntPtr dvarAddress { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00030D23 File Offset: 0x0002EF23
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00030D2B File Offset: 0x0002EF2B
		public string dvarFriendlyName { get; set; }

		// Token: 0x06000091 RID: 145 RVA: 0x00030D34 File Offset: 0x0002EF34
		public CustomSliderDialog(AiryzMemory Memory, Addresses Addys)
		{
			this.InitializeComponent();
			this.memory = Memory;
			this.addresses = Addys;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00030D50 File Offset: 0x0002EF50
		private void SingleCommandTextbox_KeyUp(object sender, KeyEventArgs e)
		{
			Key key = e.Key;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0002F842 File Offset: 0x0002DA42
		private void CancelButton_Click(object sender, RoutedEventArgs e)
		{
			base.DialogResult = new bool?(false);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00030D5C File Offset: 0x0002EF5C
		private void SearchButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				DvarFinder dvarFinder = new DvarFinder(this.memory, this.addresses);
				string text = this.DvarNameTextbox.Text.Trim();
				dvarFinder.dvars.Add(text);
				dvarFinder.findDvars(false);
				IntPtr intPtr = dvarFinder.returnedDvars[text].address;
				if (intPtr != (IntPtr)24)
				{
					this.dvarAddress = intPtr;
					intPtr = IntPtr.Subtract(intPtr, 24);
					Dvars.dvar_t dvar_t = this.memory.ReadStruct<Dvars.dvar_t>(intPtr);
					this.DvarTypeTextbox.Text = dvar_t.type.ToString();
					this.FriendlyNameTextbox.Text = this.DvarNameTextbox.Text;
					this.dvarType = dvar_t.type;
					this.dvarName = text;
					Console.WriteLine(this.dvarType.ToString());
					Console.WriteLine(this.dvarAddress.ToString("X"));
					switch (dvar_t.type)
					{
					case dvarType_t.FLOAT:
						this.DvarMinTextbox.Text = dvar_t.domain.vector.min.ToString();
						this.DvarMaxTextbox.Text = dvar_t.domain.vector.max.ToString();
						this.DvarCurrentTextbox.Text = dvar_t.current.value.ToString();
						this.dvarCurrent = dvar_t.current.value;
						goto IL_293;
					case dvarType_t.FLOAT_3:
					case dvarType_t.FLOAT_4:
						this.DvarMinTextbox.Text = dvar_t.domain.vector.min.ToString();
						this.DvarMaxTextbox.Text = dvar_t.domain.vector.max.ToString();
						this.DvarCurrentTextbox.Text = dvar_t.current.value.ToString();
						this.dvarCurrent = dvar_t.current.vector.X;
						goto IL_293;
					case dvarType_t.INT:
						this.DvarMinTextbox.Text = dvar_t.domain.integer.min.ToString();
						this.DvarMaxTextbox.Text = dvar_t.domain.integer.max.ToString();
						this.DvarCurrentTextbox.Text = dvar_t.current.integer.ToString();
						this.dvarCurrent = dvar_t.current.integer;
						goto IL_293;
					}
					this.DvarMinTextbox.Text = "";
					IL_293:
					this.DvarInfoGrid.IsEnabled = true;
				}
				else
				{
					this.SearchButton.Content = "Could not find dvar";
					Task.Run(delegate()
					{
						Thread.Sleep(5000);
						this.SearchButton.Dispatcher.Invoke(delegate()
						{
							this.SearchButton.Content = "Search";
						});
					});
					this.DvarInfoGrid.IsEnabled = false;
				}
			}
			catch
			{
				this.SearchButton.Content = "Could not find dvar";
				Task.Run(delegate()
				{
					Thread.Sleep(5000);
					this.SearchButton.Dispatcher.Invoke(delegate()
					{
						this.SearchButton.Content = "Search";
					});
				});
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0003107C File Offset: 0x0002F27C
		private void FinishedButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				switch (this.dvarType)
				{
				case dvarType_t.FLOAT:
				case dvarType_t.FLOAT_3:
				case dvarType_t.FLOAT_4:
					this.dvarMin = float.Parse(this.DvarMinTextbox.Text);
					this.dvarMax = float.Parse(this.DvarMaxTextbox.Text);
					goto IL_A2;
				case dvarType_t.INT:
					this.dvarMin = int.Parse(this.DvarMinTextbox.Text);
					this.dvarMax = int.Parse(this.DvarMaxTextbox.Text);
					goto IL_A2;
				}
				MessageBox.Show("Dvar type not supported");
				return;
				IL_A2:
				this.dvarFriendlyName = this.FriendlyNameTextbox.Text;
				base.DialogResult = new bool?(true);
			}
			catch
			{
				MessageBox.Show("Invalid dvar limits");
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00031168 File Offset: 0x0002F368
		private void SingleCommandTextbox_Populating(object sender, PopulatingEventArgs e)
		{
			CustomSliderDialog.PopulateInfo populateInfo = new CustomSliderDialog.PopulateInfo
			{
				AutoCompleteBox = (sender as AutoCompleteBox),
				SearchText = (sender as AutoCompleteBox).SearchText
			};
			e.Cancel = true;
			TaskScheduler scheduler = TaskScheduler.FromCurrentSynchronizationContext();
			Task.Factory.StartNew<CustomSliderDialog.PopulateInfo>(() => this.Populate(populateInfo)).ContinueWith(delegate(Task<CustomSliderDialog.PopulateInfo> task)
			{
				this.OnPopulateComplete(task.Result);
			}, scheduler);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000311E0 File Offset: 0x0002F3E0
		private CustomSliderDialog.PopulateInfo Populate(CustomSliderDialog.PopulateInfo populateInfo)
		{
			populateInfo.Results = (from candidate in DvarsWithDesc.DvarsWithDescriptions
			where candidate.Name.StartsWith(populateInfo.SearchText, StringComparison.InvariantCultureIgnoreCase)
			select candidate).ToList<DvarEntry>();
			return populateInfo;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00031226 File Offset: 0x0002F426
		private void OnPopulateComplete(CustomSliderDialog.PopulateInfo populateInfo)
		{
			if (populateInfo.SearchText == populateInfo.AutoCompleteBox.SearchText)
			{
				populateInfo.AutoCompleteBox.ItemsSource = populateInfo.Results;
				populateInfo.AutoCompleteBox.PopulateComplete();
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0003125C File Offset: 0x0002F45C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/BO2 Console V4;component/xaml/customsliderdialog.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0003128C File Offset: 0x0002F48C
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
				this.DvarNameTextbox = (AutoCompleteBox)target;
				this.DvarNameTextbox.KeyUp += this.SingleCommandTextbox_KeyUp;
				this.DvarNameTextbox.Populating += new PopulatingEventHandler(this.SingleCommandTextbox_Populating);
				return;
			case 4:
				this.SearchButton = (Button)target;
				this.SearchButton.Click += this.SearchButton_Click;
				return;
			case 5:
				this.DvarInfoGrid = (Grid)target;
				return;
			case 6:
				this.DvarTypeTextbox = (TextBox)target;
				return;
			case 7:
				this.DvarCurrentTextbox = (TextBox)target;
				return;
			case 8:
				this.DvarMinTextbox = (TextBox)target;
				return;
			case 9:
				this.DvarMaxTextbox = (TextBox)target;
				return;
			case 10:
				this.FinishedButton = (Button)target;
				this.FinishedButton.Click += this.FinishedButton_Click;
				return;
			case 11:
				this.FriendlyNameTextbox = (TextBox)target;
				return;
			case 12:
				this.CancelButton = (Button)target;
				this.CancelButton.Click += this.CancelButton_Click;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x04000176 RID: 374
		private AiryzMemory memory;

		// Token: 0x04000177 RID: 375
		private Addresses addresses;

		// Token: 0x0400017F RID: 383
		internal Grid MainGrid;

		// Token: 0x04000180 RID: 384
		internal ScaleTransform ApplicationScaleTransform;

		// Token: 0x04000181 RID: 385
		internal AutoCompleteBox DvarNameTextbox;

		// Token: 0x04000182 RID: 386
		internal Button SearchButton;

		// Token: 0x04000183 RID: 387
		internal Grid DvarInfoGrid;

		// Token: 0x04000184 RID: 388
		internal TextBox DvarTypeTextbox;

		// Token: 0x04000185 RID: 389
		internal TextBox DvarCurrentTextbox;

		// Token: 0x04000186 RID: 390
		internal TextBox DvarMinTextbox;

		// Token: 0x04000187 RID: 391
		internal TextBox DvarMaxTextbox;

		// Token: 0x04000188 RID: 392
		internal Button FinishedButton;

		// Token: 0x04000189 RID: 393
		internal TextBox FriendlyNameTextbox;

		// Token: 0x0400018A RID: 394
		internal Button CancelButton;

		// Token: 0x0400018B RID: 395
		private bool _contentLoaded;

		// Token: 0x02000036 RID: 54
		private class PopulateInfo
		{
			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600009F RID: 159 RVA: 0x0003144E File Offset: 0x0002F64E
			// (set) Token: 0x060000A0 RID: 160 RVA: 0x00031456 File Offset: 0x0002F656
			public AutoCompleteBox AutoCompleteBox { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x0003145F File Offset: 0x0002F65F
			// (set) Token: 0x060000A2 RID: 162 RVA: 0x00031467 File Offset: 0x0002F667
			public string SearchText { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000A3 RID: 163 RVA: 0x00031470 File Offset: 0x0002F670
			// (set) Token: 0x060000A4 RID: 164 RVA: 0x00031478 File Offset: 0x0002F678
			public IEnumerable<DvarEntry> Results { get; set; }
		}
	}
}
