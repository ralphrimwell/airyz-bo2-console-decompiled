using System;

namespace BO2_Console_V4.Classes
{
	// Token: 0x0200006A RID: 106
	public class Keybind
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0004FEBC File Offset: 0x0004E0BC
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0004FEC4 File Offset: 0x0004E0C4
		public string ControlUUID { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0004FECD File Offset: 0x0004E0CD
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0004FED5 File Offset: 0x0004E0D5
		public string FriendlyName { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0004FEDE File Offset: 0x0004E0DE
		// (set) Token: 0x0600022E RID: 558 RVA: 0x0004FEE6 File Offset: 0x0004E0E6
		public KeybindType keybindType { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0004FEF0 File Offset: 0x0004E0F0
		public string valueString
		{
			get
			{
				KeybindType keybindType = this.keybindType;
				if (keybindType - KeybindType.IncreaseBy <= 2)
				{
					return this.Value.ToString();
				}
				if (keybindType != KeybindType.SendCommand)
				{
					return "";
				}
				return this.command;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0004FF2B File Offset: 0x0004E12B
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0004FF33 File Offset: 0x0004E133
		public float Value { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0004FF3C File Offset: 0x0004E13C
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0004FF44 File Offset: 0x0004E144
		public string command { get; set; }
	}
}
