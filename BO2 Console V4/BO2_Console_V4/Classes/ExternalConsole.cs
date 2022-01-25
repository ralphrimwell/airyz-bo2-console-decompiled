using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace BO2_Console_V4.Classes
{
	// Token: 0x0200007F RID: 127
	public class ExternalConsole
	{
		// Token: 0x0600026A RID: 618
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenProcess(ExternalConsole.ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

		// Token: 0x0600026B RID: 619
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, ExternalConsole.AllocationType flAllocationType, ExternalConsole.MemoryProtection flProtect);

		// Token: 0x0600026C RID: 620
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out int lpNumberOfBytesWritten);

		// Token: 0x0600026D RID: 621
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, ExternalConsole.FreeType dwFreeType);

		// Token: 0x0600026E RID: 622
		[DllImport("kernel32.dll")]
		private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out IntPtr lpThreadId);

		// Token: 0x0600026F RID: 623 RVA: 0x000514CC File Offset: 0x0004F6CC
		public string FindGame()
		{
			string result;
			if (Process.GetProcessesByName("t6mp").Length != 0)
			{
				this.cbuf_address = 6020976U;
				this.nop_address = 9212122U;
				this.dwPID = Process.GetProcessesByName("t6mp")[0].Id;
				result = "t6mp";
			}
			else if (Process.GetProcessesByName("t6zm").Length != 0)
			{
				this.cbuf_address = 5009696U;
				this.nop_address = 9205386U;
				this.dwPID = Process.GetProcessesByName("t6zm")[0].Id;
				result = "t6zm";
			}
			else if (Process.GetProcessesByName("t6mpv43").Length != 0)
			{
				this.cbuf_address = 6057744U;
				this.nop_address = 9212474U;
				this.dwPID = Process.GetProcessesByName("t6mpv43")[0].Id;
				result = "t6mpv43";
			}
			else if (Process.GetProcessesByName("t6zmv41").Length != 0)
			{
				this.cbuf_address = 7052576U;
				this.nop_address = 9207418U;
				this.dwPID = Process.GetProcessesByName("t6zmv41")[0].Id;
				result = "t6zmv41";
			}
			else if (Process.GetProcessesByName("plutonium-bootstrapper-win32").Length != 0)
			{
				this.cbuf_address = 6057744U;
				this.nop_address = 9212474U;
				this.dwPID = Process.GetProcessesByName("plutonium-bootstrapper-win32")[0].Id;
				result = "pluto-t6";
			}
			else
			{
				this.cbuf_address = 0U;
				this.nop_address = 0U;
				result = null;
			}
			this.hProcess = ExternalConsole.OpenProcess(ExternalConsole.ProcessAccessFlags.All, false, this.dwPID);
			int num = this.nopBytes.Length;
			ExternalConsole.WriteProcessMemory(this.hProcess, (IntPtr)((long)((ulong)this.nop_address)), this.nopBytes, this.nopBytes.Length, out num);
			return result;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00051688 File Offset: 0x0004F888
		public void Send(string command)
		{
			this.FindGame();
			try
			{
				this.callbytes = BitConverter.GetBytes(this.cbuf_address);
				if (!(command == ""))
				{
					if (this.cbuf_addtext_alloc == IntPtr.Zero)
					{
						this.cbuf_addtext_alloc = ExternalConsole.VirtualAllocEx(this.hProcess, IntPtr.Zero, (IntPtr)this.cbuf_addtext_wrapper.Length, ExternalConsole.AllocationType.Commit | ExternalConsole.AllocationType.Reserve, ExternalConsole.MemoryProtection.ExecuteReadWrite);
						this.commandbytes = Encoding.ASCII.GetBytes(command);
						this.commandaddress = ExternalConsole.VirtualAllocEx(this.hProcess, IntPtr.Zero, (IntPtr)this.commandbytes.Length, ExternalConsole.AllocationType.Commit | ExternalConsole.AllocationType.Reserve, ExternalConsole.MemoryProtection.ExecuteReadWrite);
						int num = 0;
						int num2 = this.commandbytes.Length;
						ExternalConsole.WriteProcessMemory(this.hProcess, this.commandaddress, this.commandbytes, this.commandbytes.Length, out num2);
						Array.Copy(BitConverter.GetBytes(this.commandaddress.ToInt64()), 0, this.cbuf_addtext_wrapper, 9, 4);
						Array.Copy(this.callbytes, 0, this.cbuf_addtext_wrapper, 16, 4);
						ExternalConsole.WriteProcessMemory(this.hProcess, this.cbuf_addtext_alloc, this.cbuf_addtext_wrapper, this.cbuf_addtext_wrapper.Length, out num);
						IntPtr intPtr;
						ExternalConsole.CreateRemoteThread(this.hProcess, IntPtr.Zero, 0U, this.cbuf_addtext_alloc, IntPtr.Zero, 0U, out intPtr);
						if (this.cbuf_addtext_alloc != IntPtr.Zero && this.commandaddress != IntPtr.Zero)
						{
							ExternalConsole.VirtualFreeEx(this.hProcess, this.cbuf_addtext_alloc, this.cbuf_addtext_wrapper.Length, ExternalConsole.FreeType.Release);
							ExternalConsole.VirtualFreeEx(this.hProcess, this.commandaddress, this.cbuf_addtext_wrapper.Length, ExternalConsole.FreeType.Release);
						}
					}
					this.cbuf_addtext_alloc = IntPtr.Zero;
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x040003D7 RID: 983
		public byte[] cbuf_addtext_wrapper = new byte[]
		{
			85,
			139,
			236,
			131,
			236,
			8,
			199,
			69,
			248,
			0,
			0,
			0,
			0,
			199,
			69,
			252,
			0,
			0,
			0,
			0,
			byte.MaxValue,
			117,
			248,
			106,
			0,
			byte.MaxValue,
			85,
			252,
			131,
			196,
			8,
			139,
			229,
			93,
			195
		};

		// Token: 0x040003D8 RID: 984
		private IntPtr hProcess = IntPtr.Zero;

		// Token: 0x040003D9 RID: 985
		private int dwPID = -1;

		// Token: 0x040003DA RID: 986
		private uint cbuf_address;

		// Token: 0x040003DB RID: 987
		private uint nop_address;

		// Token: 0x040003DC RID: 988
		private byte[] callbytes;

		// Token: 0x040003DD RID: 989
		private IntPtr cbuf_addtext_alloc = IntPtr.Zero;

		// Token: 0x040003DE RID: 990
		private byte[] commandbytes;

		// Token: 0x040003DF RID: 991
		private IntPtr commandaddress;

		// Token: 0x040003E0 RID: 992
		private byte[] nopBytes = new byte[]
		{
			144,
			144
		};

		// Token: 0x02000080 RID: 128
		[Flags]
		public enum ProcessAccessFlags : uint
		{
			// Token: 0x040003E2 RID: 994
			All = 2035711U,
			// Token: 0x040003E3 RID: 995
			Terminate = 1U,
			// Token: 0x040003E4 RID: 996
			CreateThread = 2U,
			// Token: 0x040003E5 RID: 997
			VirtualMemoryOperation = 8U,
			// Token: 0x040003E6 RID: 998
			VirtualMemoryRead = 16U,
			// Token: 0x040003E7 RID: 999
			VirtualMemoryWrite = 32U,
			// Token: 0x040003E8 RID: 1000
			DuplicateHandle = 64U,
			// Token: 0x040003E9 RID: 1001
			CreateProcess = 128U,
			// Token: 0x040003EA RID: 1002
			SetQuota = 256U,
			// Token: 0x040003EB RID: 1003
			SetInformation = 512U,
			// Token: 0x040003EC RID: 1004
			QueryInformation = 1024U,
			// Token: 0x040003ED RID: 1005
			QueryLimitedInformation = 4096U,
			// Token: 0x040003EE RID: 1006
			Synchronize = 1048576U
		}

		// Token: 0x02000081 RID: 129
		[Flags]
		public enum FreeType
		{
			// Token: 0x040003F0 RID: 1008
			Decommit = 16384,
			// Token: 0x040003F1 RID: 1009
			Release = 32768
		}

		// Token: 0x02000082 RID: 130
		[Flags]
		public enum AllocationType
		{
			// Token: 0x040003F3 RID: 1011
			Commit = 4096,
			// Token: 0x040003F4 RID: 1012
			Reserve = 8192,
			// Token: 0x040003F5 RID: 1013
			Decommit = 16384,
			// Token: 0x040003F6 RID: 1014
			Release = 32768,
			// Token: 0x040003F7 RID: 1015
			Reset = 524288,
			// Token: 0x040003F8 RID: 1016
			Physical = 4194304,
			// Token: 0x040003F9 RID: 1017
			TopDown = 1048576,
			// Token: 0x040003FA RID: 1018
			WriteWatch = 2097152,
			// Token: 0x040003FB RID: 1019
			LargePages = 536870912
		}

		// Token: 0x02000083 RID: 131
		[Flags]
		public enum MemoryProtection
		{
			// Token: 0x040003FD RID: 1021
			Execute = 16,
			// Token: 0x040003FE RID: 1022
			ExecuteRead = 32,
			// Token: 0x040003FF RID: 1023
			ExecuteReadWrite = 64,
			// Token: 0x04000400 RID: 1024
			ExecuteWriteCopy = 128,
			// Token: 0x04000401 RID: 1025
			NoAccess = 1,
			// Token: 0x04000402 RID: 1026
			ReadOnly = 2,
			// Token: 0x04000403 RID: 1027
			ReadWrite = 4,
			// Token: 0x04000404 RID: 1028
			WriteCopy = 8,
			// Token: 0x04000405 RID: 1029
			GuardModifierflag = 256,
			// Token: 0x04000406 RID: 1030
			NoCacheModifierflag = 512,
			// Token: 0x04000407 RID: 1031
			WriteCombineModifierflag = 1024
		}
	}
}
