using System;
using System.Collections.Generic;
using System.Linq;

namespace BO2_Console_V4.Classes
{
	// Token: 0x0200006D RID: 109
	internal class Login
	{
		// Token: 0x06000235 RID: 565 RVA: 0x000317A6 File Offset: 0x0002F9A6
		public static bool CheckForInternetConnection()
		{
			return true;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0004FF50 File Offset: 0x0004E150
		public static bool Contains(List<string> IDs, string name, Func<int, int, bool> callback)
		{
			int arg = IDs.Count<string>();
			int num = 0;
			foreach (string a in IDs)
			{
				num++;
				if (callback != null)
				{
					callback(num, arg);
				}
				if (a == name)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0004FFC0 File Offset: 0x0004E1C0
		public static LoginResult Verify(string ID, Func<int, int, bool> callback)
		{
			return new LoginResult
			{
				Success = true,
				Reason = "Success",
				_reason = LoginReason.sucess
			};
		}
	}
}
