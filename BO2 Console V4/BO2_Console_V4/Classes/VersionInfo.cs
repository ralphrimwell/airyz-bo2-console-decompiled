using System;
using System.Collections.Generic;
using System.Reflection;

namespace BO2_Console_V4.Classes
{
	// Token: 0x0200007A RID: 122
	[Obfuscation(Exclude = false, Feature = "-rename")]
	public class VersionInfo
	{
		// Token: 0x06000254 RID: 596 RVA: 0x00050B75 File Offset: 0x0004ED75
		public VersionInfo()
		{
			this.VerifiedPlugins = new List<string>();
		}

		// Token: 0x040003BE RID: 958
		public string Version;

		// Token: 0x040003BF RID: 959
		public string ChangeLog;

		// Token: 0x040003C0 RID: 960
		public List<string> VerifiedPlugins;
	}
}
