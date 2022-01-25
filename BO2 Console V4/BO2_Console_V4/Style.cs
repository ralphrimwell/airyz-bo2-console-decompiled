using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;

namespace BO2_Console_V4
{
	// Token: 0x02000039 RID: 57
	public class Style : ResourceDictionary, IComponentConnector, IStyleConnector
	{
		// Token: 0x060000AB RID: 171 RVA: 0x000314C0 File Offset: 0x0002F6C0
		public Style()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000314CE File Offset: 0x0002F6CE
		private void StatusBar_MouseDown(object sender, MouseButtonEventArgs e)
		{
			((Window)((FrameworkElement)sender).TemplatedParent).DragMove();
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000314E8 File Offset: 0x0002F6E8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (this._contentLoaded)
			{
				return;
			}
			this._contentLoaded = true;
			Uri resourceLocator = new Uri("/BO2 Console V4;component/xaml/style.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00031518 File Offset: 0x0002F718
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			this._contentLoaded = true;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00031521 File Offset: 0x0002F721
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((StatusBar)target).MouseDown += this.StatusBar_MouseDown;
			}
		}

		// Token: 0x04000192 RID: 402
		private bool _contentLoaded;
	}
}
