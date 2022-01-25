using System;
using System.Collections.Generic;
using System.Diagnostics;
using Airyz;
using BO2_Console_V4.Classes;

namespace BO2_Console_V4
{
	// Token: 0x0200000A RID: 10
	public class Addresses
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00002440 File Offset: 0x00000640
		public void ReadAllAddresses()
		{
			if (Process.GetProcessesByName("t6mpv43").Length != 0 || Process.GetProcessesByName("plutonium-bootstrapper-win32").Length != 0)
			{
				if (Process.GetProcessesByName("t6mpv43").Length != 0)
				{
					this.bo2 = new AiryzMemory("t6mpv43");
				}
				if (Process.GetProcessesByName("plutonium-bootstrapper-win32").Length != 0)
				{
					this.bo2 = new AiryzMemory("plutonium-bootstrapper-win32");
					Console.WriteLine("Loading Plutonium");
				}
				IntPtr baseAddress = this.bo2.GetBaseAddress();
				this.Dvar_FindMalleableVar = (int)baseAddress + 5015888;
				this.fogPatchAddress = IntPtr.Add(baseAddress, 3306967);
				this.bo2.WriteByteArray(this.fogPatchAddress, new byte[]
				{
					184,
					184,
					36,
					98,
					3,
					144
				}, true);
				this.DB_FindXAssetHeader = IntPtr.Add(baseAddress, 3117104);
				this.MaterialsCollection = IntPtr.Add(baseAddress, 52073344);
				this.MaterialsPatch = IntPtr.Add(baseAddress, 3665183);
				this.MaterialsPatchStatic = IntPtr.Add(baseAddress, 3665792);
				this.SkyboxModel = IntPtr.Add(baseAddress, 57206740);
				this.PlayersMaterialPatchJump = IntPtr.Add(baseAddress, 3665183);
				this.clientObjMap = IntPtr.Add(baseAddress, 35836352);
				this.objBuf = IntPtr.Add(baseAddress, 35582392);
				this.Fog = IntPtr.Add(baseAddress, 52569272);
				this.Sun = this.bo2.ReadPointer((long)((int)IntPtr.Add(baseAddress, 15628812)), 20L);
				this.disableDvarLimits = IntPtr.Add(baseAddress, 5018543);
				this.disableTheatreBarrier = IntPtr.Add(baseAddress, 34804492);
				this.disableSkull = IntPtr.Add(baseAddress, 13252868);
				this.disableSkullProtection = IntPtr.Add(baseAddress, 1481182);
				this.gfxDrawMethod = IntPtr.Add(baseAddress, 56879792);
				this.dvarFinder = new DvarFinder(this.bo2, this);
				this.playerWeaponsTheater = IntPtr.Add(baseAddress, 47179192);
				this.playerWeaponsInGame = IntPtr.Add(baseAddress, 32968024);
				this.selectedPlayerIndex = IntPtr.Add(baseAddress, 40159296);
				this.TheaterBase = IntPtr.Add(baseAddress, 47725056);
				this.ssaoDistancePatch = IntPtr.Add(baseAddress, 3574293);
				this.DemoAddress1 = IntPtr.Add(baseAddress, 48252624);
				this.DemoAddress2 = IntPtr.Add(baseAddress, 48256632);
				this.DemoSummaryAddress = IntPtr.Zero;
				this.DemoThumbnailAddress = IntPtr.Add(baseAddress, 45185592);
				this.DemoThumbnailAddress2 = IntPtr.Add(baseAddress, 45849272);
				this.DemoLoadPatch = IntPtr.Add(baseAddress, 1866214);
				this.DemoNameAddress = IntPtr.Add(baseAddress, 45185074);
				this.Tick = IntPtr.Add(baseAddress, 13976864);
				this.EndTick = IntPtr.Add(baseAddress, 47133808);
				this.dvarFinder.dvars = this.defaultDvars;
				this.dvarFinder.findDvars(true);
			}
			else if (Process.GetProcessesByName("t6mp").Length != 0)
			{
				this.bo2 = new AiryzMemory("t6mp");
				IntPtr baseAddress2 = this.bo2.GetBaseAddress();
				this.Dvar_FindMalleableVar = (int)baseAddress2 + 5015536;
				this.fogPatchAddress = IntPtr.Add(baseAddress2, 3303703);
				this.bo2.WriteByteArray(this.fogPatchAddress, new byte[]
				{
					184,
					184,
					52,
					100,
					3,
					144
				}, true);
				this.DB_FindXAssetHeader = IntPtr.Add(baseAddress2, 2143760);
				this.MaterialsCollection = IntPtr.Add(baseAddress2, 52208512);
				this.MaterialsPatch = IntPtr.Add(baseAddress2, 3661935);
				this.MaterialsPatchStatic = IntPtr.Add(baseAddress2, 3662544);
				this.SkyboxModel = IntPtr.Add(baseAddress2, 57341908);
				this.PlayersMaterialPatchJump = IntPtr.Add(baseAddress2, 3661935);
				this.clientObjMap = IntPtr.Add(baseAddress2, 35836352);
				this.objBuf = IntPtr.Add(baseAddress2, 35582392);
				this.Fog = IntPtr.Add(baseAddress2, 52704440);
				this.Sun = this.bo2.ReadPointer((long)((int)IntPtr.Add(baseAddress2, 15628812)), 20L);
				this.disableDvarLimits = IntPtr.Add(baseAddress2, 5018191);
				this.disableTheatreBarrier = IntPtr.Add(baseAddress2, 34804492);
				this.disableSkull = IntPtr.Add(baseAddress2, 13252868);
				this.disableSkullProtection = IntPtr.Add(baseAddress2, 3089902);
				this.gfxDrawMethod = IntPtr.Add(baseAddress2, 57014960);
				this.dvarFinder = new DvarFinder(this.bo2, this);
				this.playerWeaponsInGame = IntPtr.Zero;
				this.ssaoDistancePatch = IntPtr.Add(baseAddress2, 3571045);
				this.DemoAddress1 = IntPtr.Add(baseAddress2, 48387792);
				this.DemoAddress2 = IntPtr.Add(baseAddress2, 48391800);
				this.DemoSummaryAddress = IntPtr.Add(baseAddress2, 45501248);
				this.DemoSummarySize = IntPtr.Add(baseAddress2, 15402416);
				this.DemoThumbnailAddress = IntPtr.Add(baseAddress2, 45984440);
				this.DemoThumbnailAddress2 = IntPtr.Zero;
				this.DemoLoadPatch = IntPtr.Add(baseAddress2, 1098742);
				this.DemoNameAddress = IntPtr.Add(baseAddress2, 45983922);
				this.Tick = IntPtr.Zero;
				this.EndTick = IntPtr.Zero;
				this.selectedPlayerIndex = IntPtr.Zero;
				this.playerWeaponsTheater = IntPtr.Zero;
				this.TheaterBase = IntPtr.Zero;
				this.dvarFinder.dvars = this.defaultDvars;
				this.dvarFinder.findDvars(true);
			}
			else if (Process.GetProcessesByName("t6zmv41").Length != 0)
			{
				this.bo2 = new AiryzMemory("t6zmv41");
				IntPtr baseAddress3 = this.bo2.GetBaseAddress();
				this.Dvar_FindMalleableVar = (int)baseAddress3 + 5010832;
				this.fogPatchAddress = IntPtr.Add(baseAddress3, 3300535);
				this.bo2.WriteByteArray(this.fogPatchAddress, new byte[]
				{
					184,
					184,
					34,
					95,
					3,
					144
				}, true);
				this.DB_FindXAssetHeader = IntPtr.Add(baseAddress3, 259168);
				this.MaterialsCollection = IntPtr.Add(baseAddress3, 51876224);
				this.MaterialsPatch = IntPtr.Add(baseAddress3, 3658319);
				this.MaterialsPatchStatic = IntPtr.Add(baseAddress3, 3658928);
				this.SkyboxModel = IntPtr.Add(baseAddress3, 57009620);
				this.PlayersMaterialPatchJump = IntPtr.Add(baseAddress3, 3658319);
				this.clientObjMap = IntPtr.Add(baseAddress3, 35642088);
				this.objBuf = IntPtr.Add(baseAddress3, 35388128);
				this.Fog = IntPtr.Add(baseAddress3, 52372152);
				this.Sun = this.bo2.ReadPointer((long)((int)IntPtr.Add(baseAddress3, 15452300)), 20L);
				this.disableDvarLimits = IntPtr.Add(baseAddress3, 5013487);
				this.disableTheatreBarrier = IntPtr.Add(baseAddress3, 34614924);
				this.disableSkull = IntPtr.Zero;
				this.disableSkullProtection = IntPtr.Zero;
				this.gfxDrawMethod = IntPtr.Add(baseAddress3, 56682672);
				this.dvarFinder = new DvarFinder(this.bo2, this);
				this.playerWeaponsTheater = IntPtr.Zero;
				this.playerWeaponsInGame = IntPtr.Zero;
				this.selectedPlayerIndex = IntPtr.Add(baseAddress3, 39964704);
				this.TheaterBase = IntPtr.Add(baseAddress3, 47528576);
				this.ssaoDistancePatch = IntPtr.Add(baseAddress3, 3567429);
				this.DemoAddress1 = IntPtr.Add(baseAddress3, 48056144);
				this.DemoAddress2 = IntPtr.Add(baseAddress3, 48060152);
				this.DemoThumbnailAddress = IntPtr.Add(baseAddress3, 44989744);
				this.DemoThumbnailAddress2 = IntPtr.Add(baseAddress3, 45653376);
				this.DemoLoadPatch = IntPtr.Add(baseAddress3, 1357702);
				this.DemoNameAddress = IntPtr.Zero;
				this.Tick = IntPtr.Add(baseAddress3, 13800240);
				this.EndTick = IntPtr.Add(baseAddress3, 46937328);
				this.dvarFinder.dvars = this.defaultDvars;
				this.dvarFinder.findDvars(true);
			}
			else if (Process.GetProcessesByName("t6zm").Length != 0)
			{
				this.bo2 = new AiryzMemory("t6zm");
				IntPtr baseAddress4 = this.bo2.GetBaseAddress();
				this.Dvar_FindMalleableVar = (int)baseAddress4 + 5008800;
				this.fogPatchAddress = IntPtr.Add(baseAddress4, 3294503);
				this.bo2.WriteByteArray(this.fogPatchAddress, new byte[]
				{
					184,
					56,
					139,
					97,
					3,
					144
				}, true);
				this.DB_FindXAssetHeader = IntPtr.Add(baseAddress4, 2932560);
				this.MaterialsCollection = IntPtr.Add(baseAddress4, 52034048);
				this.MaterialsPatch = IntPtr.Add(baseAddress4, 3652271);
				this.MaterialsPatchStatic = IntPtr.Add(baseAddress4, 3652880);
				this.SkyboxModel = IntPtr.Add(baseAddress4, 57167444);
				this.PlayersMaterialPatchJump = IntPtr.Add(baseAddress4, 3652271);
				this.clientObjMap = IntPtr.Add(baseAddress4, 35664064);
				this.objBuf = IntPtr.Add(baseAddress4, 35410104);
				this.Fog = IntPtr.Add(baseAddress4, 52529976);
				this.Sun = this.bo2.ReadPointer((long)((int)IntPtr.Add(baseAddress4, 15456524)), 20L);
				this.disableDvarLimits = IntPtr.Add(baseAddress4, 5011455);
				this.gfxDrawMethod = IntPtr.Add(baseAddress4, 56840496);
				this.ssaoDistancePatch = IntPtr.Add(baseAddress4, 3561509);
				this.Tick = IntPtr.Zero;
				this.EndTick = IntPtr.Zero;
				this.selectedPlayerIndex = IntPtr.Zero;
				this.playerWeaponsTheater = IntPtr.Zero;
				this.TheaterBase = IntPtr.Zero;
				this.DemoAddress1 = IntPtr.Zero;
				this.DemoAddress2 = IntPtr.Zero;
				this.DemoThumbnailAddress = IntPtr.Zero;
				this.DemoThumbnailAddress2 = IntPtr.Zero;
				this.DemoLoadPatch = IntPtr.Zero;
				this.DemoNameAddress = IntPtr.Zero;
				this.playerWeaponsTheater = IntPtr.Zero;
				this.playerWeaponsInGame = IntPtr.Zero;
				this.selectedPlayerIndex = IntPtr.Zero;
				this.disableTheatreBarrier = IntPtr.Zero;
				this.dvarFinder = new DvarFinder(this.bo2, this);
				this.dvarFinder.dvars = this.defaultDvars;
				this.dvarFinder.findDvars(true);
			}
			if (this.dvarFinder != null && this.dvarFinder.returnedDvars.Count > 0)
			{
				this.r_ssao = this.dvarFinder.returnedDvars["r_ssao"].address;
				this.r_dof_enable = this.dvarFinder.returnedDvars["r_dof_enable"].address;
				this.r_dof_tweak = this.dvarFinder.returnedDvars["r_dof_tweak"].address;
				this.r_dof_nearBlur = this.dvarFinder.returnedDvars["r_dof_nearBlur"].address;
				this.r_dof_farBlur = this.dvarFinder.returnedDvars["r_dof_farBlur"].address;
				this.r_dof_viewModelStart = this.dvarFinder.returnedDvars["r_dof_viewModelStart"].address;
				this.r_dof_viewModelEnd = this.dvarFinder.returnedDvars["r_dof_viewModelEnd"].address;
				this.r_dof_nearStart = this.dvarFinder.returnedDvars["r_dof_nearStart"].address;
				this.r_dof_nearEnd = this.dvarFinder.returnedDvars["r_dof_nearEnd"].address;
				this.r_dof_farStart = this.dvarFinder.returnedDvars["r_dof_farStart"].address;
				this.r_dof_farEnd = this.dvarFinder.returnedDvars["r_dof_farEnd"].address;
				this.r_dof_bias = this.dvarFinder.returnedDvars["r_dof_bias"].address;
				this.r_dof_showdebug = this.dvarFinder.returnedDvars["r_dof_showdebug"].address;
				this.r_dofHDR = this.dvarFinder.returnedDvars["r_dofHDR"].address;
				this.timescale = this.dvarFinder.returnedDvars["timescale"].address;
				this.r_sky_intensity_factor0 = this.dvarFinder.returnedDvars["r_sky_intensity_factor0"].address;
				this.r_skyColorTemp = this.dvarFinder.returnedDvars["r_skyColorTemp"].address;
				this.r_skyTransition = this.dvarFinder.returnedDvars["r_skyTransition"].address;
				this.r_skyrotation = this.dvarFinder.returnedDvars["r_skyrotation"].address;
				this.r_zfar = this.dvarFinder.returnedDvars["r_zfar"].address;
				this.r_exposureTweak = this.dvarFinder.returnedDvars["r_exposureTweak"].address;
				this.r_exposureValue = this.dvarFinder.returnedDvars["r_exposureValue"].address;
				this.cg_useColorControl = this.dvarFinder.returnedDvars["cg_useColorControl"].address;
				this.cg_colorSaturation = this.dvarFinder.returnedDvars["cg_colorSaturation"].address;
				this.cg_colorScaleR = this.dvarFinder.returnedDvars["cg_colorScale"].address;
				this.cg_colorScaleG = this.dvarFinder.returnedDvars["cg_colorScale"].address + 4;
				this.cg_colorScaleB = this.dvarFinder.returnedDvars["cg_colorScale"].address + 8;
				this.cg_drawGun = this.dvarFinder.returnedDvars["cg_drawGun"].address;
				this.cg_draw2D = this.dvarFinder.returnedDvars["cg_draw2D"].address;
				this.r_modellimit = this.dvarFinder.returnedDvars["r_modellimit"].address;
				this.r_skipPvs = this.dvarFinder.returnedDvars["r_skipPvs"].address;
				this.r_clearColor = this.dvarFinder.returnedDvars["r_clearColor"].address;
				this.r_clearColor2 = this.dvarFinder.returnedDvars["r_clearColor2"].address;
				this.r_bloomTweaks = this.dvarFinder.returnedDvars["r_bloomTweaks"].address;
				this.r_znear = this.dvarFinder.returnedDvars["r_znear"].address;
				this.r_enablePlayerShadow = this.dvarFinder.returnedDvars["r_enablePlayerShadow"].address;
				this.r_debugShader = this.dvarFinder.returnedDvars["r_debugShader"].address;
				this.r_heroLightScaleR = this.dvarFinder.returnedDvars["r_heroLightScale"].address;
				this.r_heroLightScaleG = this.dvarFinder.returnedDvars["r_heroLightScale"].address + 4;
				this.r_heroLightScaleB = this.dvarFinder.returnedDvars["r_heroLightScale"].address + 8;
				this.r_zfar = this.dvarFinder.returnedDvars["r_zfar"].address;
				this.flareDisableEffects = this.dvarFinder.returnedDvars["flareDisableEffects"].address;
				this.r_superFlareDraw = this.dvarFinder.returnedDvars["r_superFlareDraw"].address;
				this.r_dobjLimit = this.dvarFinder.returnedDvars["r_dobjLimit"].address;
				this.r_lightTweakSunDirection_readOnly = this.dvarFinder.returnedDvars["r_lightTweakSunDirection"].address;
				this.sm_sunQuality = this.dvarFinder.returnedDvars["sm_sunQuality"].address;
				this.UI_MapName = this.dvarFinder.returnedDvars["ui_mapname"].address;
			}
		}

		// Token: 0x04000021 RID: 33
		private IntPtr fogPatchAddress;

		// Token: 0x04000022 RID: 34
		public IntPtr Fog;

		// Token: 0x04000023 RID: 35
		public IntPtr Sun;

		// Token: 0x04000024 RID: 36
		public IntPtr r_ssao;

		// Token: 0x04000025 RID: 37
		public IntPtr r_dof_enable;

		// Token: 0x04000026 RID: 38
		public IntPtr r_dof_tweak;

		// Token: 0x04000027 RID: 39
		public IntPtr r_dof_nearBlur;

		// Token: 0x04000028 RID: 40
		public IntPtr r_dof_farBlur;

		// Token: 0x04000029 RID: 41
		public IntPtr r_dof_viewModelStart;

		// Token: 0x0400002A RID: 42
		public IntPtr r_dof_viewModelEnd;

		// Token: 0x0400002B RID: 43
		public IntPtr r_dof_nearStart;

		// Token: 0x0400002C RID: 44
		public IntPtr r_dof_nearEnd;

		// Token: 0x0400002D RID: 45
		public IntPtr r_dof_farStart;

		// Token: 0x0400002E RID: 46
		public IntPtr r_dof_farEnd;

		// Token: 0x0400002F RID: 47
		public IntPtr r_dof_bias;

		// Token: 0x04000030 RID: 48
		public IntPtr r_dof_showdebug;

		// Token: 0x04000031 RID: 49
		public IntPtr r_dofHDR;

		// Token: 0x04000032 RID: 50
		public IntPtr r_exposureTweak;

		// Token: 0x04000033 RID: 51
		public IntPtr r_exposureValue;

		// Token: 0x04000034 RID: 52
		public IntPtr cg_useColorControl;

		// Token: 0x04000035 RID: 53
		public IntPtr cg_colorSaturation;

		// Token: 0x04000036 RID: 54
		public IntPtr cg_colorScaleR;

		// Token: 0x04000037 RID: 55
		public IntPtr cg_colorScaleG;

		// Token: 0x04000038 RID: 56
		public IntPtr cg_colorScaleB;

		// Token: 0x04000039 RID: 57
		public IntPtr cg_drawGun;

		// Token: 0x0400003A RID: 58
		public IntPtr cg_draw2D;

		// Token: 0x0400003B RID: 59
		public IntPtr r_modellimit;

		// Token: 0x0400003C RID: 60
		public IntPtr r_skipPvs;

		// Token: 0x0400003D RID: 61
		public IntPtr r_clearColor;

		// Token: 0x0400003E RID: 62
		public IntPtr r_clearColor2;

		// Token: 0x0400003F RID: 63
		public IntPtr r_bloomTweaks;

		// Token: 0x04000040 RID: 64
		public IntPtr r_heroLightScaleR;

		// Token: 0x04000041 RID: 65
		public IntPtr r_heroLightScaleG;

		// Token: 0x04000042 RID: 66
		public IntPtr r_heroLightScaleB;

		// Token: 0x04000043 RID: 67
		public IntPtr timescale;

		// Token: 0x04000044 RID: 68
		public IntPtr UI_MapName;

		// Token: 0x04000045 RID: 69
		public IntPtr r_sky_intensity_factor0;

		// Token: 0x04000046 RID: 70
		public IntPtr r_skyColorTemp;

		// Token: 0x04000047 RID: 71
		public IntPtr r_skyTransition;

		// Token: 0x04000048 RID: 72
		public IntPtr r_skyrotation;

		// Token: 0x04000049 RID: 73
		public IntPtr r_zfar;

		// Token: 0x0400004A RID: 74
		public IntPtr r_znear;

		// Token: 0x0400004B RID: 75
		public IntPtr flareDisableEffects;

		// Token: 0x0400004C RID: 76
		public IntPtr r_superFlareDraw;

		// Token: 0x0400004D RID: 77
		public IntPtr r_dobjLimit;

		// Token: 0x0400004E RID: 78
		public IntPtr r_enablePlayerShadow;

		// Token: 0x0400004F RID: 79
		public IntPtr r_debugShader;

		// Token: 0x04000050 RID: 80
		public IntPtr disableDvarLimits;

		// Token: 0x04000051 RID: 81
		public IntPtr disableTheatreBarrier;

		// Token: 0x04000052 RID: 82
		public IntPtr disableSkull;

		// Token: 0x04000053 RID: 83
		public IntPtr disableSkullProtection;

		// Token: 0x04000054 RID: 84
		public IntPtr r_lightTweakSunDirection_readOnly;

		// Token: 0x04000055 RID: 85
		public IntPtr sm_sunQuality;

		// Token: 0x04000056 RID: 86
		public IntPtr DB_FindXAssetHeader;

		// Token: 0x04000057 RID: 87
		public IntPtr MaterialsCollection;

		// Token: 0x04000058 RID: 88
		public IntPtr MaterialsPatch;

		// Token: 0x04000059 RID: 89
		public IntPtr MaterialsPatchStatic;

		// Token: 0x0400005A RID: 90
		public IntPtr SkyboxModel;

		// Token: 0x0400005B RID: 91
		public IntPtr PlayersMaterialPatchJump;

		// Token: 0x0400005C RID: 92
		public IntPtr objBuf;

		// Token: 0x0400005D RID: 93
		public IntPtr clientObjMap;

		// Token: 0x0400005E RID: 94
		public IntPtr gfxDrawMethod;

		// Token: 0x0400005F RID: 95
		public IntPtr playerWeaponsInGame;

		// Token: 0x04000060 RID: 96
		public IntPtr playerWeaponsTheater;

		// Token: 0x04000061 RID: 97
		public IntPtr selectedPlayerIndex;

		// Token: 0x04000062 RID: 98
		public IntPtr TheaterBase;

		// Token: 0x04000063 RID: 99
		public IntPtr DemoNameAddress;

		// Token: 0x04000064 RID: 100
		public IntPtr DemoAddress1;

		// Token: 0x04000065 RID: 101
		public IntPtr DemoAddress2;

		// Token: 0x04000066 RID: 102
		public IntPtr DemoSummaryLengthAddress;

		// Token: 0x04000067 RID: 103
		public IntPtr DemoSummaryAddress;

		// Token: 0x04000068 RID: 104
		public IntPtr DemoSummarySize;

		// Token: 0x04000069 RID: 105
		public IntPtr DemoThumbnailAddress;

		// Token: 0x0400006A RID: 106
		public IntPtr DemoThumbnailAddress2;

		// Token: 0x0400006B RID: 107
		public IntPtr DemoLoadPatch;

		// Token: 0x0400006C RID: 108
		public IntPtr ssaoDistancePatch;

		// Token: 0x0400006D RID: 109
		public IntPtr Tick;

		// Token: 0x0400006E RID: 110
		public IntPtr EndTick;

		// Token: 0x0400006F RID: 111
		public int Dvar_FindMalleableVar;

		// Token: 0x04000070 RID: 112
		private AiryzMemory bo2;

		// Token: 0x04000071 RID: 113
		public DvarFinder dvarFinder;

		// Token: 0x04000072 RID: 114
		public List<string> defaultDvars = new List<string>
		{
			"cg_fov",
			"r_skyrotation",
			"r_zfar",
			"r_dof_farBlur",
			"r_dof_nearBlur",
			"r_dof_tweak",
			"r_dof_enable",
			"r_dof_viewModelStart",
			"r_dof_viewModelEnd",
			"r_dof_nearStart",
			"r_dof_nearEnd",
			"r_dof_farStart",
			"r_dof_farEnd",
			"r_dof_bias",
			"r_dof_showdebug",
			"r_dofHDR",
			"ui_mapname",
			"timescale",
			"r_ssao",
			"r_sky_intensity_factor0",
			"r_skyColorTemp",
			"r_skyTransition",
			"r_exposureTweak",
			"r_exposureValue",
			"cg_useColorControl",
			"cg_colorSaturation",
			"cg_colorScale",
			"cg_drawGun",
			"cg_draw2D",
			"r_modellimit",
			"r_skipPvs",
			"r_clearColor",
			"r_clearColor2",
			"r_bloomTweaks",
			"r_znear",
			"r_enablePlayerShadow",
			"r_heroLightScale",
			"flareDisableEffects",
			"r_superFlareDraw",
			"r_dobjLimit",
			"r_lightTweakSunDirection",
			"sm_sunQuality",
			"r_debugShader"
		};
	}
}
