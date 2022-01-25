using System;

namespace BO2_Console_V4.Classes
{
	// Token: 0x02000079 RID: 121
	internal class UIDGenerator
	{
		// Token: 0x06000252 RID: 594 RVA: 0x00050B26 File Offset: 0x0004ED26
		public UIDGenerator()
		{
			this.r = new Random(48879);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00050B40 File Offset: 0x0004ED40
		public string GetUID()
		{
			byte[] array = new byte[16];
			this.r.NextBytes(array);
			return new Guid(array).ToString();
		}

		// Token: 0x040003BD RID: 957
		private Random r;
	}
}
