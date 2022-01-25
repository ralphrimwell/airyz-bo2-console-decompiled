using System;
using System.Reflection;
using BO2PluginFramework;

namespace BO2_Console_V4
{
	// Token: 0x02000009 RID: 9
	[Obfuscation(Exclude = false, Feature = "-rename")]
	internal class CustomSliderAddress
	{
		// Token: 0x04000017 RID: 23
		public dvarType_t type;

		// Token: 0x04000018 RID: 24
		public string name;

		// Token: 0x04000019 RID: 25
		public string friendlyName;

		// Token: 0x0400001A RID: 26
		public int offset;

		// Token: 0x0400001B RID: 27
		public int intMin;

		// Token: 0x0400001C RID: 28
		public int intMax;

		// Token: 0x0400001D RID: 29
		public float fMin;

		// Token: 0x0400001E RID: 30
		public float fMax;

		// Token: 0x0400001F RID: 31
		public int intdefaultValue;

		// Token: 0x04000020 RID: 32
		public float fDefaultValue;
	}
}
