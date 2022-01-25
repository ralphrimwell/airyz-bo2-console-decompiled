using System;
using System.ComponentModel;

namespace BO2_Console_V4
{
	// Token: 0x02000003 RID: 3
	internal class GlobalKeyboardHookEventArgs : HandledEventArgs
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020CE File Offset: 0x000002CE
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000020D6 File Offset: 0x000002D6
		public GlobalKeyboardHook.KeyboardState KeyboardState { get; private set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020DF File Offset: 0x000002DF
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000020E7 File Offset: 0x000002E7
		public GlobalKeyboardHook.LowLevelKeyboardInputEvent KeyboardData { get; private set; }

		// Token: 0x0600000C RID: 12 RVA: 0x000020F0 File Offset: 0x000002F0
		public GlobalKeyboardHookEventArgs(GlobalKeyboardHook.LowLevelKeyboardInputEvent keyboardData, GlobalKeyboardHook.KeyboardState keyboardState)
		{
			this.KeyboardData = keyboardData;
			this.KeyboardState = keyboardState;
		}
	}
}
