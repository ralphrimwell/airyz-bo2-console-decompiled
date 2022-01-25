using System;
using System.Collections.Generic;

namespace BO2_Console_V4.Info
{
	// Token: 0x02000054 RID: 84
	public static class WeaponIDs
	{
		// Token: 0x040002C4 RID: 708
		public static Dictionary<string, int> SMGsMP = new Dictionary<string, int>
		{
			{
				"MP7",
				2
			},
			{
				"PDW-57",
				4
			},
			{
				"Vector K10",
				6
			},
			{
				"MSMC",
				8
			},
			{
				"Chicom CQB",
				10
			},
			{
				"Skorpion EVO",
				12
			},
			{
				"Peacekeeper",
				14
			}
		};

		// Token: 0x040002C5 RID: 709
		public static Dictionary<string, int> AssaultRiflesMP = new Dictionary<string, int>
		{
			{
				"MTAR",
				16
			},
			{
				"Type 25",
				20
			},
			{
				"SWAT-556",
				24
			},
			{
				"FAL OSW",
				28
			},
			{
				"M27",
				32
			},
			{
				"SCAR-H",
				36
			},
			{
				"SMR",
				40
			},
			{
				"M8A1",
				44
			},
			{
				"AN94",
				48
			}
		};

		// Token: 0x040002C6 RID: 710
		public static Dictionary<string, int> ShotgunsMP = new Dictionary<string, int>
		{
			{
				"R870 MCS",
				52
			},
			{
				"S12",
				53
			},
			{
				"KSG",
				54
			},
			{
				"M1216",
				55
			}
		};

		// Token: 0x040002C7 RID: 711
		public static Dictionary<string, int> LMGsMP = new Dictionary<string, int>
		{
			{
				"Mk 48",
				56
			},
			{
				"QBB LSW",
				58
			},
			{
				"LSAT",
				60
			},
			{
				"HAMR",
				62
			}
		};

		// Token: 0x040002C8 RID: 712
		public static Dictionary<string, int> SnipersMP = new Dictionary<string, int>
		{
			{
				"SVU-AS",
				64
			},
			{
				"DSR 50",
				65
			},
			{
				"Ballista",
				66
			},
			{
				"XPR-50",
				67
			}
		};

		// Token: 0x040002C9 RID: 713
		public static Dictionary<string, int> PistolsMP = new Dictionary<string, int>
		{
			{
				"Five-seven",
				78
			},
			{
				"Tac-45",
				79
			},
			{
				"B23R",
				80
			},
			{
				"Executioner",
				81
			},
			{
				"KAP-40",
				82
			}
		};

		// Token: 0x040002CA RID: 714
		public static Dictionary<string, int> LaunchersMP = new Dictionary<string, int>
		{
			{
				"SMAW",
				84
			},
			{
				"FHJ-18 AA",
				85
			},
			{
				"RPG",
				86
			}
		};

		// Token: 0x040002CB RID: 715
		public static Dictionary<string, int> SpecialsMP = new Dictionary<string, int>
		{
			{
				"Riot Shield",
				89
			},
			{
				"Crossbow",
				90
			},
			{
				"Ballistic Knives",
				91
			}
		};

		// Token: 0x040002CC RID: 716
		public static Dictionary<string, Dictionary<string, int>> Weapons = new Dictionary<string, Dictionary<string, int>>
		{
			{
				"SMGs",
				WeaponIDs.SMGsMP
			},
			{
				"Assault Rifles",
				WeaponIDs.AssaultRiflesMP
			},
			{
				"Shotguns",
				WeaponIDs.ShotgunsMP
			},
			{
				"LMGs",
				WeaponIDs.LMGsMP
			},
			{
				"Snipers",
				WeaponIDs.SnipersMP
			},
			{
				"Pistols",
				WeaponIDs.PistolsMP
			},
			{
				"Launchers",
				WeaponIDs.LaunchersMP
			},
			{
				"Specials",
				WeaponIDs.SpecialsMP
			}
		};

		// Token: 0x02000055 RID: 85
		public struct Weapon
		{
			// Token: 0x040002CD RID: 717
			public string name;

			// Token: 0x040002CE RID: 718
			public int ID;
		}

		// Token: 0x02000056 RID: 86
		public enum Attachments
		{
			// Token: 0x040002D0 RID: 720
			ATTACHMENT_NONE,
			// Token: 0x040002D1 RID: 721
			ATTACHMENT_ACOG,
			// Token: 0x040002D2 RID: 722
			ATTACHMENT_DUALCLIP,
			// Token: 0x040002D3 RID: 723
			ATTACHMENT_DUALOPTIC,
			// Token: 0x040002D4 RID: 724
			ATTACHMENT_DW,
			// Token: 0x040002D5 RID: 725
			ATTACHMENT_EXTBARREL,
			// Token: 0x040002D6 RID: 726
			ATTACHMENT_EXTCLIP,
			// Token: 0x040002D7 RID: 727
			ATTACHMENT_EXTRAMAGS,
			// Token: 0x040002D8 RID: 728
			ATTACHMENT_FASTADS,
			// Token: 0x040002D9 RID: 729
			ATTACHMENT_FASTRELOAD,
			// Token: 0x040002DA RID: 730
			ATTACHMENT_FMJ,
			// Token: 0x040002DB RID: 731
			ATTACHMENT_GL,
			// Token: 0x040002DC RID: 732
			ATTACHMENT_GRIP,
			// Token: 0x040002DD RID: 733
			ATTACHMENT_HOLO,
			// Token: 0x040002DE RID: 734
			ATTACHMENT_IR,
			// Token: 0x040002DF RID: 735
			ATTACHMENT_IRONSIGHTS,
			// Token: 0x040002E0 RID: 736
			ATTACHMENT_LONGBREATH,
			// Token: 0x040002E1 RID: 737
			ATTACHMENT_MK,
			// Token: 0x040002E2 RID: 738
			ATTACHMENT_MMS,
			// Token: 0x040002E3 RID: 739
			ATTACHMENT_RANGEFINDER,
			// Token: 0x040002E4 RID: 740
			ATTACHMENT_REFLEX,
			// Token: 0x040002E5 RID: 741
			ATTACHMENT_RF,
			// Token: 0x040002E6 RID: 742
			ATTACHMENT_SELECTFIRE,
			// Token: 0x040002E7 RID: 743
			ATTACHMENT_SILENCER,
			// Token: 0x040002E8 RID: 744
			ATTACHMENT_STACKFIRE,
			// Token: 0x040002E9 RID: 745
			ATTACHMENT_STALKER,
			// Token: 0x040002EA RID: 746
			ATTACHMENT_STEADYAIM,
			// Token: 0x040002EB RID: 747
			ATTACHMENT_SWAYREDUC,
			// Token: 0x040002EC RID: 748
			ATTACHMENT_TACKNIFE,
			// Token: 0x040002ED RID: 749
			ATTACHMENT_VZOOM,
			// Token: 0x040002EE RID: 750
			ATTACHMENT_TYPE_COUNT,
			// Token: 0x040002EF RID: 751
			ATTACHMENT_INVALID = 30
		}
	}
}
