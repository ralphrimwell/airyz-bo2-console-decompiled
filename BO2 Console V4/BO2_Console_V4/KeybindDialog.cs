using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using BO2_Console_V4.Classes;

namespace BO2_Console_V4
{
	// Token: 0x0200002D RID: 45
	public class KeybindDialog : Window, IComponentConnector
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0002F698 File Offset: 0x0002D898
		// (set) Token: 0x0600003A RID: 58 RVA: 0x0002F6A0 File Offset: 0x0002D8A0
		public Keys Key { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0002F6A9 File Offset: 0x0002D8A9
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0002F6B1 File Offset: 0x0002D8B1
		public KeybindType Type { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0002F6BA File Offset: 0x0002D8BA
		// (set) Token: 0x0600003E RID: 62 RVA: 0x0002F6C2 File Offset: 0x0002D8C2
		public string Value { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0002F6CB File Offset: 0x0002D8CB
		// (set) Token: 0x06000040 RID: 64 RVA: 0x0002F6D3 File Offset: 0x0002D8D3
		public string BindName { get; set; }

		// Token: 0x06000041 RID: 65 RVA: 0x0002F6DC File Offset: 0x0002D8DC
		public KeybindDialog(KeybindHost host)
		{
			this.InitializeComponent();
			this.KeybindTypeLabel.Content = "Keybind Controller: " + host.ToString();
			switch (host)
			{
			case KeybindHost.Button:
				this.KeybindTypeSelector.ItemsSource = new List<KeybindType>
				{
					KeybindType.Click
				};
				this.ValueGrid.Visibility = Visibility.Hidden;
				break;
			case KeybindHost.Slider:
				this.KeybindTypeSelector.ItemsSource = new List<KeybindType>
				{
					KeybindType.IncreaseBy,
					KeybindType.DecreaseBy,
					KeybindType.SetValue
				};
				this.ValueGrid.Visibility = Visibility.Visible;
				break;
			case KeybindHost.Checkbox:
				this.KeybindTypeSelector.ItemsSource = new List<KeybindType>
				{
					KeybindType.Toggle
				};
				this.ValueGrid.Visibility = Visibility.Hidden;
				break;
			case KeybindHost.Custom:
				this.KeybindTypeSelector.ItemsSource = new List<KeybindType>
				{
					KeybindType.SendCommand,
					KeybindType.BringToFront
				};
				this.ValueGrid.Visibility = Visibility.Visible;
				break;
			}
			this.KeybindTypeSelector.SelectedIndex = 0;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0002F7E8 File Offset: 0x0002D9E8
		private void TestForValidSelection()
		{
			if (this.KeybindTypeSelector.SelectedIndex >= 0 && this.KeyInputTextbox.Text.Length > 0 && this.KeybindNameTextbox.Text.Length > 0)
			{
				this.FinishedButton.IsEnabled = true;
				return;
			}
			this.FinishedButton.IsEnabled = false;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0002F842 File Offset: 0x0002DA42
		private void CancelButton_Click(object sender, RoutedEventArgs e)
		{
			base.DialogResult = new bool?(false);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0002F850 File Offset: 0x0002DA50
		private void FinishedButton_Click(object sender, RoutedEventArgs e)
		{
			this.Type = (KeybindType)this.KeybindTypeSelector.SelectedItem;
			this.Value = this.ValueTextBox.Text;
			this.BindName = this.KeybindNameTextbox.Text;
			base.DialogResult = new bool?(true);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0002F8A4 File Offset: 0x0002DAA4
		private void KeyInputTextbox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			this.KeyInputTextbox.Text = e.Key.ToString();
			this.KeyInputTextbox.CaretIndex = this.KeyInputTextbox.Text.Length;
			e.Handled = true;
			this.Key = (Keys)KeyInterop.VirtualKeyFromKey(e.Key);
			this.TestForValidSelection();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0002F909 File Offset: 0x0002DB09
		private void KeybindTypeSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			this.TestForValidSelection();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0002F914 File Offset: 0x0002DB14
		private void ValueTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			object selectedItem = this.KeybindTypeSelector.SelectedItem;
			if (selectedItem is KeybindType)
			{
				KeybindType keybindType = (KeybindType)selectedItem;
				if (keybindType - KeybindType.IncreaseBy <= 2)
				{
					if (this.ValueTextBox.Text.Count((char f) => f == '.') == 1 && e.Text == ".")
					{
						e.Handled = true;
						return;
					}
					Regex regex = new Regex("[^0-9.]+");
					e.Handled = regex.IsMatch(e.Text);
				}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0002F909 File Offset: 0x0002DB09
		private void ValueTextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			this.TestForValidSelection();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0002F909 File Offset: 0x0002DB09
		private void KeybindNameTextbox_TextChanged(object sender, TextChangedEventArgs e)
		{
			this.TestForValidSelection();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0002F9AC File Offset: 0x0002DBAC
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/BO2 Console V4;component/xaml/keybinddialog.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0002F9DC File Offset: 0x0002DBDC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
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
				this.CancelButton = (System.Windows.Controls.Button)target;
				this.CancelButton.Click += this.CancelButton_Click;
				return;
			case 4:
				this.FinishedButton = (System.Windows.Controls.Button)target;
				this.FinishedButton.Click += this.FinishedButton_Click;
				return;
			case 5:
				this.KeybindTypeLabel = (System.Windows.Controls.Label)target;
				return;
			case 6:
				this.KeybindTypeSelector = (System.Windows.Controls.ComboBox)target;
				this.KeybindTypeSelector.SelectionChanged += this.KeybindTypeSelector_SelectionChanged;
				return;
			case 7:
				this.KeyInputTextbox = (System.Windows.Controls.TextBox)target;
				this.KeyInputTextbox.KeyDown += this.KeyInputTextbox_KeyDown;
				return;
			case 8:
				this.ValueGrid = (Grid)target;
				return;
			case 9:
				this.ValueTextBox = (System.Windows.Controls.TextBox)target;
				this.ValueTextBox.PreviewTextInput += this.ValueTextBox_PreviewTextInput;
				this.ValueTextBox.TextChanged += this.ValueTextBox_TextChanged;
				return;
			case 10:
				this.KeybindNameTextbox = (System.Windows.Controls.TextBox)target;
				this.KeybindNameTextbox.TextChanged += this.KeybindNameTextbox_TextChanged;
				return;
			default:
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x04000131 RID: 305
		internal Grid MainGrid;

		// Token: 0x04000132 RID: 306
		internal ScaleTransform ApplicationScaleTransform;

		// Token: 0x04000133 RID: 307
		internal System.Windows.Controls.Button CancelButton;

		// Token: 0x04000134 RID: 308
		internal System.Windows.Controls.Button FinishedButton;

		// Token: 0x04000135 RID: 309
		internal System.Windows.Controls.Label KeybindTypeLabel;

		// Token: 0x04000136 RID: 310
		internal System.Windows.Controls.ComboBox KeybindTypeSelector;

		// Token: 0x04000137 RID: 311
		internal System.Windows.Controls.TextBox KeyInputTextbox;

		// Token: 0x04000138 RID: 312
		internal Grid ValueGrid;

		// Token: 0x04000139 RID: 313
		internal System.Windows.Controls.TextBox ValueTextBox;

		// Token: 0x0400013A RID: 314
		internal System.Windows.Controls.TextBox KeybindNameTextbox;

		// Token: 0x0400013B RID: 315
		private bool _contentLoaded;
	}
}
