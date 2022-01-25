using System;
using System.Windows.Forms;

namespace BO2_Console_V4.Classes
{
	// Token: 0x0200005C RID: 92
	internal class DemoFileBuilder
	{
		// Token: 0x060001FE RID: 510 RVA: 0x0004F170 File Offset: 0x0004D370
		public DemoFileBuilder(string gamemode, string map)
		{
			try
			{
				this.MapByte = (byte)((DemoFileBuilder.Map)Enum.Parse(typeof(DemoFileBuilder.Map), map));
			}
			catch
			{
				MessageBox.Show("Error parsing map byte");
			}
			try
			{
				this.GamemodeByte = (byte)((DemoFileBuilder.GameMode)Enum.Parse(typeof(DemoFileBuilder.GameMode), gamemode));
			}
			catch
			{
				MessageBox.Show("Error parsing gamemode byte");
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0004F214 File Offset: 0x0004D414
		public byte[] GetTags()
		{
			byte[] demoTagsTemplate = this.DemoTagsTemplate;
			demoTagsTemplate[33] = this.MapByte;
			demoTagsTemplate[51] = this.GamemodeByte;
			return demoTagsTemplate;
		}

		// Token: 0x0400030F RID: 783
		private byte[] DemoTagsTemplate = new byte[]
		{
			8,
			16,
			0,
			0,
			0,
			10,
			3,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			2,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			15,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			13,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			4,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			157,
			52,
			201,
			81,
			4,
			0,
			16,
			3,
			10,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			1,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			10,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			2,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			10,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			3,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			10,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			4,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			10,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			5,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			10,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			6,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			10,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			7,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			10,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			8,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			10,
			8,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			9,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			byte.MaxValue,
			10,
			6,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			5,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			10,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0
		};

		// Token: 0x04000310 RID: 784
		public byte MapByte;

		// Token: 0x04000311 RID: 785
		public byte GamemodeByte;

		// Token: 0x0200005D RID: 93
		public enum Map
		{
			// Token: 0x04000313 RID: 787
			mp_la,
			// Token: 0x04000314 RID: 788
			mp_cargo,
			// Token: 0x04000315 RID: 789
			mp_carrier,
			// Token: 0x04000316 RID: 790
			mp_drone,
			// Token: 0x04000317 RID: 791
			mp_express,
			// Token: 0x04000318 RID: 792
			mp_hijacked,
			// Token: 0x04000319 RID: 793
			mp_meltdown,
			// Token: 0x0400031A RID: 794
			mp_overflow,
			// Token: 0x0400031B RID: 795
			mp_nightclub,
			// Token: 0x0400031C RID: 796
			mp_raid,
			// Token: 0x0400031D RID: 797
			mp_slums,
			// Token: 0x0400031E RID: 798
			mp_village,
			// Token: 0x0400031F RID: 799
			mp_turbine,
			// Token: 0x04000320 RID: 800
			mp_socotra,
			// Token: 0x04000321 RID: 801
			mp_nuketown,
			// Token: 0x04000322 RID: 802
			mp_downhill,
			// Token: 0x04000323 RID: 803
			mp_mirage,
			// Token: 0x04000324 RID: 804
			mp_hydro,
			// Token: 0x04000325 RID: 805
			mp_skate,
			// Token: 0x04000326 RID: 806
			mp_concert,
			// Token: 0x04000327 RID: 807
			mp_magma,
			// Token: 0x04000328 RID: 808
			mp_vertigo,
			// Token: 0x04000329 RID: 809
			mp_studio,
			// Token: 0x0400032A RID: 810
			mp_uplink,
			// Token: 0x0400032B RID: 811
			mp_bridge,
			// Token: 0x0400032C RID: 812
			mp_castaway,
			// Token: 0x0400032D RID: 813
			mp_paintball,
			// Token: 0x0400032E RID: 814
			mp_dig,
			// Token: 0x0400032F RID: 815
			mp_frostbite,
			// Token: 0x04000330 RID: 816
			mp_pod,
			// Token: 0x04000331 RID: 817
			mp_takeoff
		}

		// Token: 0x0200005E RID: 94
		public enum GameMode
		{
			// Token: 0x04000333 RID: 819
			tdm = 1,
			// Token: 0x04000334 RID: 820
			dm,
			// Token: 0x04000335 RID: 821
			dom,
			// Token: 0x04000336 RID: 822
			dem,
			// Token: 0x04000337 RID: 823
			conf,
			// Token: 0x04000338 RID: 824
			koth,
			// Token: 0x04000339 RID: 825
			hq,
			// Token: 0x0400033A RID: 826
			ctf,
			// Token: 0x0400033B RID: 827
			sd,
			// Token: 0x0400033C RID: 828
			oneflag = 14,
			// Token: 0x0400033D RID: 829
			gun = 10,
			// Token: 0x0400033E RID: 830
			oic,
			// Token: 0x0400033F RID: 831
			shrp,
			// Token: 0x04000340 RID: 832
			sas
		}
	}
}
