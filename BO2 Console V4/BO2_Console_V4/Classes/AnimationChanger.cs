using System;
using System.Collections.Generic;
using System.Windows;
using Airyz;

namespace BO2_Console_V4.Classes
{
	// Token: 0x02000057 RID: 87
	public static class AnimationChanger
	{
		// Token: 0x060001EB RID: 491 RVA: 0x0004E8E8 File Offset: 0x0004CAE8
		private static bool isValidAnim(IntPtr address)
		{
			if (address == IntPtr.Zero)
			{
				return false;
			}
			Structures.XAnimParts xanimParts = AnimationChanger.memory.ReadStruct<Structures.XAnimParts>(address);
			return xanimParts.dataByteCount != 1941 || xanimParts.dataShortCount != 150 || xanimParts.dataIntCount != 99 || xanimParts.randomDataByteCount != 711 || xanimParts.numFrames != 80;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0004E94E File Offset: 0x0004CB4E
		public static IntPtr GetAnimationAddress(string name)
		{
			return (IntPtr)AnimationChanger.memory.CallFunction86(AnimationChanger.addresses.DB_FindXAssetHeader, new object[]
			{
				4,
				name,
				true,
				-1
			});
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0004E990 File Offset: 0x0004CB90
		private static bool AnimationsAreCompatible(IntPtr anim1, IntPtr anim2)
		{
			ref Structures.XAnimParts ptr = AnimationChanger.memory.ReadStruct<Structures.XAnimParts>(anim1);
			Structures.XAnimParts xanimParts = AnimationChanger.memory.ReadStruct<Structures.XAnimParts>(anim2);
			return ptr.boneCount == xanimParts.boneCount;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0004E9C4 File Offset: 0x0004CBC4
		public static AnimationChanger.AnimationChangeResult ReplaceAnim(string anim1_name, string anim2_name)
		{
			IntPtr address = IntPtr.Zero;
			if (!AnimationChanger.originalData.ContainsKey(anim1_name))
			{
				address = AnimationChanger.GetAnimationAddress(anim1_name);
				if (AnimationChanger.isValidAnim(address))
				{
					AnimationChanger.AnimData value = new AnimationChanger.AnimData
					{
						Address = address,
						Data = AnimationChanger.memory.ReadByteArray(address, 104)
					};
					AnimationChanger.originalData.Add(anim1_name, value);
				}
			}
			else
			{
				address = AnimationChanger.originalData[anim1_name].Address;
			}
			IntPtr animationAddress = AnimationChanger.GetAnimationAddress(anim2_name);
			Console.WriteLine("Anim1: " + address.ToString("X"));
			Console.WriteLine("Anim2: " + animationAddress.ToString("X"));
			bool flag = AnimationChanger.isValidAnim(address);
			bool flag2 = AnimationChanger.isValidAnim(animationAddress);
			if (!flag && !flag2)
			{
				return AnimationChanger.AnimationChangeResult.BothBad;
			}
			if (!flag)
			{
				return AnimationChanger.AnimationChangeResult.Anim1Bad;
			}
			if (!flag2)
			{
				return AnimationChanger.AnimationChangeResult.Anim2Bad;
			}
			byte[] bytes = AnimationChanger.memory.ReadByteArray(animationAddress, 104);
			AnimationChanger.memory.WriteByteArray(address, bytes, true);
			return AnimationChanger.AnimationChangeResult.Good;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0004EAB8 File Offset: 0x0004CCB8
		public static void test(string model1, string model2)
		{
			IntPtr address = (IntPtr)AnimationChanger.memory.CallFunction86(AnimationChanger.addresses.DB_FindXAssetHeader, new object[]
			{
				5,
				"t6_wpn_sniper_dsr50_view",
				true,
				-1
			});
			IntPtr address2 = (IntPtr)AnimationChanger.memory.CallFunction86(AnimationChanger.addresses.DB_FindXAssetHeader, new object[]
			{
				5,
				"t6_wpn_sniper_ballista_view",
				true,
				-1
			});
			MessageBox.Show(address2.ToString("X"));
			MessageBox.Show(address.ToString("X"));
			int length = 248;
			byte[] bytes = AnimationChanger.memory.ReadByteArray(address2, length);
			AnimationChanger.memory.WriteByteArray(address, bytes, true);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0004EB90 File Offset: 0x0004CD90
		public static void RestoreAll()
		{
			foreach (string key in AnimationChanger.originalData.Keys)
			{
				AnimationChanger.memory.WriteByteArray(AnimationChanger.originalData[key].Address, AnimationChanger.originalData[key].Data);
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0004EC0C File Offset: 0x0004CE0C
		public static void RestoreSingle(string name)
		{
			if (AnimationChanger.originalData.ContainsKey(name))
			{
				AnimationChanger.memory.WriteByteArray(AnimationChanger.originalData[name].Address, AnimationChanger.originalData[name].Data);
			}
		}

		// Token: 0x040002F0 RID: 752
		public static AiryzMemory memory;

		// Token: 0x040002F1 RID: 753
		public static Addresses addresses;

		// Token: 0x040002F2 RID: 754
		private const int XAnimParts_Size = 104;

		// Token: 0x040002F3 RID: 755
		private static Dictionary<string, AnimationChanger.AnimData> originalData = new Dictionary<string, AnimationChanger.AnimData>();

		// Token: 0x02000058 RID: 88
		public enum AnimationChangeResult
		{
			// Token: 0x040002F5 RID: 757
			Good,
			// Token: 0x040002F6 RID: 758
			Anim1Bad,
			// Token: 0x040002F7 RID: 759
			Anim2Bad,
			// Token: 0x040002F8 RID: 760
			BothBad,
			// Token: 0x040002F9 RID: 761
			incompatible
		}

		// Token: 0x02000059 RID: 89
		private struct AnimData
		{
			// Token: 0x040002FA RID: 762
			public IntPtr Address;

			// Token: 0x040002FB RID: 763
			public byte[] Data;
		}
	}
}
