using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BO2_Console_V4
{
	// Token: 0x02000004 RID: 4
	internal class GlobalKeyboardHook : IDisposable
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000D RID: 13 RVA: 0x00002108 File Offset: 0x00000308
		// (remove) Token: 0x0600000E RID: 14 RVA: 0x00002140 File Offset: 0x00000340
		public event EventHandler<GlobalKeyboardHookEventArgs> KeyboardPressed;

		// Token: 0x0600000F RID: 15 RVA: 0x00002178 File Offset: 0x00000378
		public GlobalKeyboardHook(Keys[] registeredKeys = null)
		{
			GlobalKeyboardHook.RegisteredKeys = registeredKeys;
			this._windowsHookHandle = IntPtr.Zero;
			this._user32LibraryHandle = IntPtr.Zero;
			this._hookProc = new GlobalKeyboardHook.HookProc(this.LowLevelKeyboardProc);
			this._user32LibraryHandle = GlobalKeyboardHook.LoadLibrary("User32");
			if (this._user32LibraryHandle == IntPtr.Zero)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				throw new Win32Exception(lastWin32Error, string.Format("Failed to load library 'User32.dll'. Error {0}: {1}.", lastWin32Error, new Win32Exception(Marshal.GetLastWin32Error()).Message));
			}
			this._windowsHookHandle = GlobalKeyboardHook.SetWindowsHookEx(13, this._hookProc, this._user32LibraryHandle, 0);
			if (this._windowsHookHandle == IntPtr.Zero)
			{
				int lastWin32Error2 = Marshal.GetLastWin32Error();
				throw new Win32Exception(lastWin32Error2, string.Format("Failed to adjust keyboard hooks for '{0}'. Error {1}: {2}.", Process.GetCurrentProcess().ProcessName, lastWin32Error2, new Win32Exception(Marshal.GetLastWin32Error()).Message));
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000226C File Offset: 0x0000046C
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this._windowsHookHandle != IntPtr.Zero)
			{
				if (!GlobalKeyboardHook.UnhookWindowsHookEx(this._windowsHookHandle))
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					throw new Win32Exception(lastWin32Error, string.Format("Failed to remove keyboard hooks for '{0}'. Error {1}: {2}.", Process.GetCurrentProcess().ProcessName, lastWin32Error, new Win32Exception(Marshal.GetLastWin32Error()).Message));
				}
				this._windowsHookHandle = IntPtr.Zero;
				this._hookProc = (GlobalKeyboardHook.HookProc)Delegate.Remove(this._hookProc, new GlobalKeyboardHook.HookProc(this.LowLevelKeyboardProc));
			}
			if (this._user32LibraryHandle != IntPtr.Zero)
			{
				if (!GlobalKeyboardHook.FreeLibrary(this._user32LibraryHandle))
				{
					int lastWin32Error2 = Marshal.GetLastWin32Error();
					throw new Win32Exception(lastWin32Error2, string.Format("Failed to unload library 'User32.dll'. Error {0}: {1}.", lastWin32Error2, new Win32Exception(Marshal.GetLastWin32Error()).Message));
				}
				this._user32LibraryHandle = IntPtr.Zero;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002358 File Offset: 0x00000558
		~GlobalKeyboardHook()
		{
			this.Dispose(false);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002388 File Offset: 0x00000588
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000013 RID: 19
		[DllImport("kernel32.dll")]
		private static extern IntPtr LoadLibrary(string lpFileName);

		// Token: 0x06000014 RID: 20
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		private static extern bool FreeLibrary(IntPtr hModule);

		// Token: 0x06000015 RID: 21
		[DllImport("USER32", SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook, GlobalKeyboardHook.HookProc lpfn, IntPtr hMod, int dwThreadId);

		// Token: 0x06000016 RID: 22
		[DllImport("USER32", SetLastError = true)]
		public static extern bool UnhookWindowsHookEx(IntPtr hHook);

		// Token: 0x06000017 RID: 23
		[DllImport("USER32", SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hHook, int code, IntPtr wParam, IntPtr lParam);

		// Token: 0x06000018 RID: 24 RVA: 0x00002398 File Offset: 0x00000598
		public IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam)
		{
			bool flag = false;
			int num = wParam.ToInt32();
			if (Enum.IsDefined(typeof(GlobalKeyboardHook.KeyboardState), num))
			{
				GlobalKeyboardHook.LowLevelKeyboardInputEvent lowLevelKeyboardInputEvent = (GlobalKeyboardHook.LowLevelKeyboardInputEvent)Marshal.PtrToStructure(lParam, typeof(GlobalKeyboardHook.LowLevelKeyboardInputEvent));
				GlobalKeyboardHookEventArgs globalKeyboardHookEventArgs = new GlobalKeyboardHookEventArgs(lowLevelKeyboardInputEvent, (GlobalKeyboardHook.KeyboardState)num);
				Keys virtualCode = (Keys)lowLevelKeyboardInputEvent.VirtualCode;
				if (GlobalKeyboardHook.RegisteredKeys == null || GlobalKeyboardHook.RegisteredKeys.Contains(virtualCode))
				{
					EventHandler<GlobalKeyboardHookEventArgs> keyboardPressed = this.KeyboardPressed;
					if (keyboardPressed != null)
					{
						keyboardPressed(this, globalKeyboardHookEventArgs);
					}
					flag = globalKeyboardHookEventArgs.Handled;
				}
			}
			if (!flag)
			{
				return GlobalKeyboardHook.CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
			}
			return (IntPtr)1;
		}

		// Token: 0x04000004 RID: 4
		private IntPtr _windowsHookHandle;

		// Token: 0x04000005 RID: 5
		private IntPtr _user32LibraryHandle;

		// Token: 0x04000006 RID: 6
		private GlobalKeyboardHook.HookProc _hookProc;

		// Token: 0x04000007 RID: 7
		public const int WH_KEYBOARD_LL = 13;

		// Token: 0x04000008 RID: 8
		public static Keys[] RegisteredKeys;

		// Token: 0x04000009 RID: 9
		private const int KfAltdown = 8192;

		// Token: 0x0400000A RID: 10
		public const int LlkhfAltdown = 32;

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600001A RID: 26
		private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

		// Token: 0x02000006 RID: 6
		public struct LowLevelKeyboardInputEvent
		{
			// Token: 0x17000003 RID: 3
			// (get) Token: 0x0600001D RID: 29 RVA: 0x0000242E File Offset: 0x0000062E
			public Keys Key
			{
				get
				{
					return (Keys)this.VirtualCode;
				}
			}

			// Token: 0x0400000B RID: 11
			public int VirtualCode;

			// Token: 0x0400000C RID: 12
			public int HardwareScanCode;

			// Token: 0x0400000D RID: 13
			public int Flags;

			// Token: 0x0400000E RID: 14
			public int TimeStamp;

			// Token: 0x0400000F RID: 15
			public IntPtr AdditionalInformation;
		}

		// Token: 0x02000007 RID: 7
		public enum KeyboardState
		{
			// Token: 0x04000011 RID: 17
			KeyDown = 256,
			// Token: 0x04000012 RID: 18
			KeyUp,
			// Token: 0x04000013 RID: 19
			SysKeyDown = 260,
			// Token: 0x04000014 RID: 20
			SysKeyUp
		}
	}
}
