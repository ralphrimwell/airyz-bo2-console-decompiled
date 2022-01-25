using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using BO2_Console_V4.Classes;

namespace BO2_Console_V4
{
	// Token: 0x0200002F RID: 47
	public class StreamableLoginDialog : Window, IComponentConnector
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0002FB5B File Offset: 0x0002DD5B
		// (set) Token: 0x06000050 RID: 80 RVA: 0x0002FB63 File Offset: 0x0002DD63
		public string username { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0002FB6C File Offset: 0x0002DD6C
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0002FB74 File Offset: 0x0002DD74
		public string password { get; set; }

		// Token: 0x06000053 RID: 83 RVA: 0x0002FB7D File Offset: 0x0002DD7D
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[StreamableLoginDialog.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0002FBB8 File Offset: 0x0002DDB8
		public StreamableLoginDialog()
		{
			this.InitializeComponent();
			SolidColorBrush solidColorBrush = (SolidColorBrush)base.Resources["DefaultBackground"];
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0002FBDC File Offset: 0x0002DDDC
		private bool callback(bool result)
		{
			this.FinishedButton.Dispatcher.Invoke(delegate()
			{
				this.ToggleGrid.IsEnabled = true;
				if (result)
				{
					this.FinishedButton.Content = "Success!";
					this.username = this.StreamableUsernameTextbox.Text;
					this.password = this.StreamablePasswordTextbox.Password;
					this.DialogResult = new bool?(true);
					return;
				}
				this.FinishedButton.Content = "Login Failed: Invalid Credentials";
			});
			return true;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0002FC1C File Offset: 0x0002DE1C
		private void FinishedButton_Click(object sender, RoutedEventArgs e)
		{
			this.FinishedButton.Content = "Logging in...";
			this.ToggleGrid.IsEnabled = false;
			StreamableAPI.TestLogin(this.StreamableUsernameTextbox.Text, this.StreamablePasswordTextbox.Password, new Func<bool, bool>(this.callback));
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0002F842 File Offset: 0x0002DA42
		private void CancelButton_Click(object sender, RoutedEventArgs e)
		{
			base.DialogResult = new bool?(false);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0002FC6C File Offset: 0x0002DE6C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/BO2 Console V4;component/xaml/streamablelogindialog.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0002FC9C File Offset: 0x0002DE9C
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
				this.ToggleGrid = (Grid)target;
				return;
			case 5:
				this.FinishedButton = (Button)target;
				this.FinishedButton.Click += this.FinishedButton_Click;
				return;
			case 6:
				this.StreamableUsernameTextbox = (TextBox)target;
				return;
			case 7:
				this.StreamablePasswordTextbox = (PasswordBox)target;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x04000140 RID: 320
		private static Random random = new Random();

		// Token: 0x04000141 RID: 321
		internal Grid MainGrid;

		// Token: 0x04000142 RID: 322
		internal ScaleTransform ApplicationScaleTransform;

		// Token: 0x04000143 RID: 323
		internal Button CancelButton;

		// Token: 0x04000144 RID: 324
		internal Grid ToggleGrid;

		// Token: 0x04000145 RID: 325
		internal Button FinishedButton;

		// Token: 0x04000146 RID: 326
		internal TextBox StreamableUsernameTextbox;

		// Token: 0x04000147 RID: 327
		internal PasswordBox StreamablePasswordTextbox;

		// Token: 0x04000148 RID: 328
		private bool _contentLoaded;
	}
}
