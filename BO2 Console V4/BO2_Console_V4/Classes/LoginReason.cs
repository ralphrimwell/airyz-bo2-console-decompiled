using System;

namespace BO2_Console_V4.Classes
{
	// Token: 0x0200006B RID: 107
	public enum LoginReason
	{
		// Token: 0x04000383 RID: 899
		tampering,
		// Token: 0x04000384 RID: 900
		sucess,
		// Token: 0x04000385 RID: 901
		banned,
		// Token: 0x04000386 RID: 902
		invalidID,
		// Token: 0x04000387 RID: 903
		HWIDInvalid,
		// Token: 0x04000388 RID: 904
		APIError,
		// Token: 0x04000389 RID: 905
		RateLimit,
		// Token: 0x0400038A RID: 906
		NoInternet
	}
}
