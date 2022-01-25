using System;
using System.Threading;
using Airyz;

namespace BO2_Console_V4.Classes
{
	// Token: 0x0200007B RID: 123
	public static class WeaponChanger
	{
		// Token: 0x06000255 RID: 597 RVA: 0x00050B88 File Offset: 0x0004ED88
		public static IntPtr GetAddress()
		{
			if (WeaponChanger.BO2.ReadInt(WeaponChanger.addresses.TheaterBase) == 0)
			{
				WeaponChanger.isTheater = false;
				return WeaponChanger.addresses.playerWeaponsInGame + 0;
			}
			WeaponChanger.isTheater = true;
			int num = WeaponChanger.BO2.ReadInt(WeaponChanger.addresses.selectedPlayerIndex);
			return WeaponChanger.addresses.playerWeaponsTheater + 10760 * num;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00050BF3 File Offset: 0x0004EDF3
		public static void EnableLoop()
		{
			WeaponChanger.loopRunning = true;
			WeaponChanger.LoopThread = new Thread(new ThreadStart(WeaponChanger.Loop));
			WeaponChanger.LoopThread.Start();
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00050C1B File Offset: 0x0004EE1B
		public static void DisableLoop()
		{
			WeaponChanger.loopRunning = false;
			WeaponChanger.LoopThread.Abort();
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00050C30 File Offset: 0x0004EE30
		public static void SetWeapon(int WeaponID)
		{
			IntPtr address = WeaponChanger.GetAddress();
			Structures.PlayerWeaponInfo playerWeaponInfo = WeaponChanger.BO2.ReadStruct<Structures.PlayerWeaponInfo>(address);
			Console.WriteLine(WeaponChanger.BO2.GetStructMemberAddress<Structures.PlayerWeaponInfo>(address, (Structures.PlayerWeaponInfo gInfo) => (object)gInfo.heldWeapon, 0).ToString("X"));
			Console.WriteLine(WeaponChanger.BO2.GetStructMemberAddress<Structures.PlayerWeaponInfo>(address, (Structures.PlayerWeaponInfo gInfo) => (object)gInfo.primaryWeapon, 0).ToString("X"));
			Console.WriteLine(WeaponChanger.BO2.GetStructMemberAddress<Structures.PlayerWeaponInfo>(address, (Structures.PlayerWeaponInfo gInfo) => (object)gInfo.secondaryWeapon, 0).ToString("X"));
			Console.WriteLine("Held Weapon: " + playerWeaponInfo.heldWeapon.ToString());
			if (WeaponChanger.isTheater)
			{
				WeaponChanger.primary = WeaponID;
				WeaponChanger.secondary = WeaponID;
			}
			else if (playerWeaponInfo.heldWeapon == playerWeaponInfo.primaryWeapon)
			{
				WeaponChanger.primary = WeaponID;
				Console.WriteLine("Primary Weapon");
			}
			else
			{
				WeaponChanger.secondary = WeaponID;
				Console.WriteLine("Secondary Weapon");
			}
			WeaponChanger.WriteWeaponData();
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00050DD8 File Offset: 0x0004EFD8
		public static void SetCamo(int CamoID)
		{
			IntPtr address = WeaponChanger.GetAddress();
			Structures.PlayerWeaponInfo playerWeaponInfo = WeaponChanger.BO2.ReadStruct<Structures.PlayerWeaponInfo>(address);
			if (WeaponChanger.isTheater)
			{
				WeaponChanger.primaryCamo = CamoID;
				WeaponChanger.secondaryCamo = CamoID;
			}
			else if (playerWeaponInfo.heldWeapon == playerWeaponInfo.primaryWeapon)
			{
				WeaponChanger.primaryCamo = CamoID;
				Console.WriteLine("Primary Weapon");
			}
			else
			{
				WeaponChanger.secondaryCamo = CamoID;
				Console.WriteLine("Secondary Weapon");
			}
			WeaponChanger.WriteWeaponData();
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00050E44 File Offset: 0x0004F044
		private static void WriteWeaponData()
		{
			IntPtr address = WeaponChanger.GetAddress();
			WeaponChanger.BO2.ReadStruct<Structures.PlayerWeaponInfo>(address);
			if (WeaponChanger.primary >= 0 || WeaponChanger.secondary >= 0)
			{
				if (WeaponChanger.isTheater)
				{
					WeaponChanger.BO2.WriteStructMember<Structures.PlayerWeaponInfo>(address, (Structures.PlayerWeaponInfo w) => (object)w.heldWeapon, WeaponChanger.primary);
					WeaponChanger.BO2.WriteStructMember<Structures.PlayerWeaponInfo>(address, (Structures.PlayerWeaponInfo w) => (object)w.primaryWeapon, WeaponChanger.primary);
					WeaponChanger.BO2.WriteStructMember<Structures.PlayerWeaponInfo>(address, (Structures.PlayerWeaponInfo w) => (object)w.secondaryWeapon, WeaponChanger.primary);
				}
				else
				{
					if (WeaponChanger.primary != -1)
					{
						WeaponChanger.BO2.WriteStructMember<Structures.PlayerWeaponInfo>(address, (Structures.PlayerWeaponInfo w) => (object)w.primaryWeapon, WeaponChanger.primary);
					}
					if (WeaponChanger.secondary != -1)
					{
						WeaponChanger.BO2.WriteStructMember<Structures.PlayerWeaponInfo>(address, (Structures.PlayerWeaponInfo w) => (object)w.secondaryWeapon, WeaponChanger.secondary);
					}
				}
			}
			Console.WriteLine(string.Format("Primary Camo: {0}", WeaponChanger.primaryCamo));
			Console.WriteLine(string.Format("Secondary Camo: {0}", WeaponChanger.secondaryCamo));
			if (WeaponChanger.primaryCamo >= 0 || WeaponChanger.secondaryCamo >= 0)
			{
				if (WeaponChanger.isTheater)
				{
					WeaponChanger.BO2.WriteStructMember<Structures.PlayerWeaponInfo>(address, (Structures.PlayerWeaponInfo w) => (object)w.primaryCamo, WeaponChanger.primaryCamo);
					WeaponChanger.BO2.WriteStructMember<Structures.PlayerWeaponInfo>(address, (Structures.PlayerWeaponInfo w) => (object)w.secondaryCamo, WeaponChanger.primaryCamo);
					return;
				}
				if (WeaponChanger.primaryCamo != -1)
				{
					Console.WriteLine("Writing Primary Camo");
					WeaponChanger.BO2.WriteStructMember<Structures.PlayerWeaponInfo>(address, (Structures.PlayerWeaponInfo w) => (object)w.primaryCamo, WeaponChanger.primaryCamo);
				}
				if (WeaponChanger.secondaryCamo != -1)
				{
					WeaponChanger.BO2.WriteStructMember<Structures.PlayerWeaponInfo>(address, (Structures.PlayerWeaponInfo w) => (object)w.secondaryCamo, WeaponChanger.secondaryCamo);
				}
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00051217 File Offset: 0x0004F417
		public static void ClearSelection()
		{
			WeaponChanger.primary = -1;
			WeaponChanger.primaryCamo = -1;
			WeaponChanger.secondary = -1;
			WeaponChanger.secondaryCamo = -1;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00051231 File Offset: 0x0004F431
		private static void Loop()
		{
			while (WeaponChanger.loopRunning)
			{
				WeaponChanger.WriteWeaponData();
				Thread.Sleep(300);
			}
		}

		// Token: 0x040003C1 RID: 961
		public static Addresses addresses;

		// Token: 0x040003C2 RID: 962
		public static AiryzMemory BO2;

		// Token: 0x040003C3 RID: 963
		private static Thread LoopThread;

		// Token: 0x040003C4 RID: 964
		public static bool loopRunning = false;

		// Token: 0x040003C5 RID: 965
		public const int len_playerState = 10760;

		// Token: 0x040003C6 RID: 966
		public static int primary = -1;

		// Token: 0x040003C7 RID: 967
		public static int primaryCamo = -1;

		// Token: 0x040003C8 RID: 968
		public static int secondary = -1;

		// Token: 0x040003C9 RID: 969
		public static int secondaryCamo = -1;

		// Token: 0x040003CA RID: 970
		private static bool isTheater = false;
	}
}
