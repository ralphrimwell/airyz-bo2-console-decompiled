using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Airyz;
using ASMdotNET;
using BO2PluginFramework;

namespace BO2_Console_V4.Classes
{
	// Token: 0x02000084 RID: 132
	public class DvarFinder
	{
		// Token: 0x06000272 RID: 626 RVA: 0x000518CC File Offset: 0x0004FACC
		public DvarFinder(AiryzMemory memory, Addresses addys)
		{
			this.mem = memory;
			this.addresses = addys;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00051904 File Offset: 0x0004FB04
		public bool findDvars(bool showErrors)
		{
			this.returnedDvars = new Dictionary<string, dvar.DvarResult>();
			this.dvarOffsets = new Dictionary<string, int>();
			int num = 4096;
			uint dwSize = (uint)(num * 3);
			IntPtr intPtr = this.mem.AllocateMemory(dwSize);
			int num2 = num;
			int num3 = num * 2;
			int num4 = (int)intPtr + num3;
			AssemblyCompiler assemblyCompiler = new AssemblyCompiler(0, (int)intPtr);
			assemblyCompiler.Add(new object[]
			{
				Opcodes.push(Registers.ebp),
				Opcodes.mov(Registers.ebp, Registers.esp)
			});
			string text = "";
			foreach (string text2 in this.dvars)
			{
				if (!this.dvarOffsets.ContainsKey(text2))
				{
					this.dvarOffsets.Add(text2, text.Length);
					text = text + text2 + "\0";
				}
			}
			this.mem.WriteStringASCII(IntPtr.Add(intPtr, num2), text);
			foreach (string key in this.dvars)
			{
				int num5 = (int)intPtr + num2 + this.dvarOffsets[key];
				int num6 = (int)intPtr + num3;
				assemblyCompiler.Add(new object[]
				{
					Opcodes.sub(Registers.esp, 8),
					Opcodes.mov(Registers.eax, num5),
					Opcodes.call(this.addresses.Dvar_FindMalleableVar),
					Opcodes.add(Registers.esp, 8),
					Opcodes.mov(num6, Registers.eax)
				});
				num3 += 4;
			}
			assemblyCompiler.Add(new object[]
			{
				Opcodes.mov(Registers.esp, Registers.ebp),
				Opcodes.pop(Registers.ebp),
				Opcodes.ret()
			});
			byte[] bytes = assemblyCompiler.Compile(Array.Empty<object>());
			this.mem.WriteByteArray(intPtr, bytes);
			this.mem.CreateThread(intPtr);
			Thread.Sleep(10);
			int num7 = 25;
			int num8 = 0;
			Console.WriteLine((num4 + (this.dvars.Count - 1) * 4).ToString("X"));
			while (this.mem.ReadInt((IntPtr)(num4 + (this.dvars.Count - 1) * 4)) == 0)
			{
				num8++;
				Thread.Sleep(10);
				if (num8 > num7)
				{
					if (showErrors)
					{
						MessageBox.Show("Dvar finder timed out. Console may not work as intended");
						break;
					}
					break;
				}
			}
			byte[] value = this.mem.ReadByteArray((IntPtr)num4, this.dvars.Count * 4);
			this.mem.FreeMemory(intPtr, 0);
			for (int i = 0; i < this.dvars.Count; i++)
			{
				IntPtr pointer = (IntPtr)BitConverter.ToInt32(value, i * 4);
				if (!this.returnedDvars.ContainsKey(this.dvars[i]))
				{
					this.returnedDvars.Add(this.dvars[i], new dvar.DvarResult
					{
						address = IntPtr.Add(pointer, 24),
						name = this.dvars[i],
						type = (dvarType_t)this.mem.ReadInt(IntPtr.Add(pointer, 16))
					});
				}
				else
				{
					this.returnedDvars[this.dvars[i]] = new dvar.DvarResult
					{
						address = IntPtr.Add(pointer, 24),
						name = this.dvars[i],
						type = (dvarType_t)this.mem.ReadInt(IntPtr.Add(pointer, 16))
					};
				}
			}
			return true;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00051CF4 File Offset: 0x0004FEF4
		public IntPtr FindSingleDvar(string DvarName)
		{
			int num = 4096;
			uint dwSize = (uint)(num * 3);
			IntPtr intPtr = this.mem.AllocateMemory(dwSize);
			int num2 = num;
			int num3 = num * 2;
			int value = (int)intPtr + num3;
			this.mem.WriteStringASCII(IntPtr.Add(intPtr, num2), DvarName);
			int num4 = (int)intPtr + num2;
			int num5 = (int)intPtr + num3;
			AssemblyCompiler assemblyCompiler = new AssemblyCompiler(0, (int)intPtr);
			assemblyCompiler.Add(new object[]
			{
				Opcodes.push(Registers.ebp),
				Opcodes.mov(Registers.ebp, Registers.esp),
				Opcodes.sub(Registers.esp, 8),
				Opcodes.mov(Registers.eax, num4),
				Opcodes.call(this.addresses.Dvar_FindMalleableVar),
				Opcodes.add(Registers.esp, 8),
				Opcodes.mov(Registers.ebx, num5),
				Opcodes.mov(~Registers.ebx, Registers.eax),
				Opcodes.mov(Registers.esp, Registers.ebp),
				Opcodes.pop(Registers.ebp),
				Opcodes.ret()
			});
			byte[] bytes = assemblyCompiler.Compile(Array.Empty<object>());
			this.mem.WriteByteArray(intPtr, bytes);
			this.mem.CreateThread(intPtr);
			Thread.Sleep(10);
			byte[] value2 = this.mem.ReadByteArray((IntPtr)value, 4);
			this.mem.FreeMemory(intPtr, 0);
			return (IntPtr)BitConverter.ToInt32(value2, 0);
		}

		// Token: 0x04000408 RID: 1032
		private AiryzMemory mem;

		// Token: 0x04000409 RID: 1033
		private Addresses addresses;

		// Token: 0x0400040A RID: 1034
		public List<string> dvars = new List<string>();

		// Token: 0x0400040B RID: 1035
		public Dictionary<string, dvar.DvarResult> returnedDvars = new Dictionary<string, dvar.DvarResult>();

		// Token: 0x0400040C RID: 1036
		private Dictionary<string, int> dvarOffsets = new Dictionary<string, int>();
	}
}
