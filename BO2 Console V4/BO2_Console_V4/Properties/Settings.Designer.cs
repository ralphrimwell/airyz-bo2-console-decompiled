using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace BO2_Console_V4.Properties
{
	// Token: 0x0200004F RID: 79
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x000400C4 File Offset: 0x0003E2C4
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040002B6 RID: 694
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
