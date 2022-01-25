using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BO2_Console_V4
{
	// Token: 0x02000019 RID: 25
	[Obfuscation(Exclude = false, Feature = "-rename")]
	public class Structures
	{
		// Token: 0x0200001A RID: 26
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct flColor
		{
			// Token: 0x040000E1 RID: 225
			public float r;

			// Token: 0x040000E2 RID: 226
			public float g;

			// Token: 0x040000E3 RID: 227
			public float b;
		}

		// Token: 0x0200001B RID: 27
		public struct Vector3
		{
			// Token: 0x040000E4 RID: 228
			public float X;

			// Token: 0x040000E5 RID: 229
			public float Y;

			// Token: 0x040000E6 RID: 230
			public float Z;
		}

		// Token: 0x0200001C RID: 28
		public struct Vector4
		{
			// Token: 0x040000E7 RID: 231
			public float X;

			// Token: 0x040000E8 RID: 232
			public float Y;

			// Token: 0x040000E9 RID: 233
			public float Z;

			// Token: 0x040000EA RID: 234
			public float W;
		}

		// Token: 0x0200001D RID: 29
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct Fog
		{
			// Token: 0x040000EB RID: 235
			public float startDist;

			// Token: 0x040000EC RID: 236
			public float fadeDist;

			// Token: 0x040000ED RID: 237
			public float startHeight;

			// Token: 0x040000EE RID: 238
			public float fadeHeight;

			// Token: 0x040000EF RID: 239
			public float sunHazePitchAngle;

			// Token: 0x040000F0 RID: 240
			public float sunHazeYawAngle;

			// Token: 0x040000F1 RID: 241
			public float hazeInnerRadius;

			// Token: 0x040000F2 RID: 242
			public float hazeOuterRadius;

			// Token: 0x040000F3 RID: 243
			public Structures.flColor fogColor;

			// Token: 0x040000F4 RID: 244
			public float fogOpacity;

			// Token: 0x040000F5 RID: 245
			public Structures.flColor sunHazeColor;

			// Token: 0x040000F6 RID: 246
			public float sunHazeOpacity;
		}

		// Token: 0x0200001E RID: 30
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct Sun
		{
			// Token: 0x040000F7 RID: 247
			public float X;

			// Token: 0x040000F8 RID: 248
			public float Y;

			// Token: 0x040000F9 RID: 249
			public float Z;

			// Token: 0x040000FA RID: 250
			[FixedBuffer(typeof(byte), 56)]
			public Structures.Sun.<padding>e__FixedBuffer padding;

			// Token: 0x040000FB RID: 251
			public Structures.flColor colour;

			// Token: 0x0200001F RID: 31
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 56)]
			public struct <padding>e__FixedBuffer
			{
				// Token: 0x040000FC RID: 252
				public byte FixedElementField;
			}
		}

		// Token: 0x02000020 RID: 32
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct Ssao
		{
			// Token: 0x040000FD RID: 253
			public byte ssao;

			// Token: 0x040000FE RID: 254
			[FixedBuffer(typeof(byte), 95)]
			public Structures.Ssao.<padding>e__FixedBuffer padding;

			// Token: 0x040000FF RID: 255
			public float scale;

			// Token: 0x04000100 RID: 256
			[FixedBuffer(typeof(byte), 92)]
			public Structures.Ssao.<padding1>e__FixedBuffer padding1;

			// Token: 0x04000101 RID: 257
			public float radius;

			// Token: 0x04000102 RID: 258
			[FixedBuffer(typeof(byte), 92)]
			public Structures.Ssao.<padding2>e__FixedBuffer padding2;

			// Token: 0x04000103 RID: 259
			public float bias;

			// Token: 0x04000104 RID: 260
			[FixedBuffer(typeof(byte), 92)]
			public Structures.Ssao.<padding3>e__FixedBuffer padding3;

			// Token: 0x04000105 RID: 261
			public float intensity;

			// Token: 0x02000021 RID: 33
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 95)]
			public struct <padding>e__FixedBuffer
			{
				// Token: 0x04000106 RID: 262
				public byte FixedElementField;
			}

			// Token: 0x02000022 RID: 34
			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Size = 92)]
			public struct <padding1>e__FixedBuffer
			{
				// Token: 0x04000107 RID: 263
				public byte FixedElementField;
			}

			// Token: 0x02000023 RID: 35
			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Size = 92)]
			public struct <padding2>e__FixedBuffer
			{
				// Token: 0x04000108 RID: 264
				public byte FixedElementField;
			}

			// Token: 0x02000024 RID: 36
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 92)]
			public struct <padding3>e__FixedBuffer
			{
				// Token: 0x04000109 RID: 265
				public byte FixedElementField;
			}
		}

		// Token: 0x02000025 RID: 37
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct GfxDrawMethod
		{
			// Token: 0x0400010A RID: 266
			public int drawScene;

			// Token: 0x0400010B RID: 267
			public byte baseTechType;

			// Token: 0x0400010C RID: 268
			public byte emisssiveTechType;

			// Token: 0x0400010D RID: 269
			[FixedBuffer(typeof(byte), 176)]
			public Structures.GfxDrawMethod.<litTechType>e__FixedBuffer litTechType;

			// Token: 0x02000026 RID: 38
			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Size = 176)]
			public struct <litTechType>e__FixedBuffer
			{
				// Token: 0x0400010E RID: 270
				public byte FixedElementField;
			}
		}

		// Token: 0x02000027 RID: 39
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct PlayerWeaponInfo
		{
			// Token: 0x0400010F RID: 271
			public int heldWeapon;

			// Token: 0x04000110 RID: 272
			[FixedBuffer(typeof(byte), 168)]
			public Structures.PlayerWeaponInfo.<padding>e__FixedBuffer padding;

			// Token: 0x04000111 RID: 273
			public int secondaryWeapon;

			// Token: 0x04000112 RID: 274
			public int secondaryCamo;

			// Token: 0x04000113 RID: 275
			[FixedBuffer(typeof(byte), 48)]
			public Structures.PlayerWeaponInfo.<padding2>e__FixedBuffer padding2;

			// Token: 0x04000114 RID: 276
			public int primaryWeapon;

			// Token: 0x04000115 RID: 277
			public int primaryCamo;

			// Token: 0x02000028 RID: 40
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 168)]
			public struct <padding>e__FixedBuffer
			{
				// Token: 0x04000116 RID: 278
				public byte FixedElementField;
			}

			// Token: 0x02000029 RID: 41
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 48)]
			public struct <padding2>e__FixedBuffer
			{
				// Token: 0x04000117 RID: 279
				public byte FixedElementField;
			}
		}

		// Token: 0x0200002A RID: 42
		public struct XAnimParts
		{
			// Token: 0x04000118 RID: 280
			public int namePointer;

			// Token: 0x04000119 RID: 281
			public short dataByteCount;

			// Token: 0x0400011A RID: 282
			public short dataShortCount;

			// Token: 0x0400011B RID: 283
			public short dataIntCount;

			// Token: 0x0400011C RID: 284
			public short randomDataByteCount;

			// Token: 0x0400011D RID: 285
			public short randomDataIntCount;

			// Token: 0x0400011E RID: 286
			public short numFrames;

			// Token: 0x0400011F RID: 287
			public byte bLoop;

			// Token: 0x04000120 RID: 288
			public byte bDelta;

			// Token: 0x04000121 RID: 289
			public byte bDelta3D;

			// Token: 0x04000122 RID: 290
			public byte bLeftHandGripIK;

			// Token: 0x04000123 RID: 291
			public int streamedFileSize;

			// Token: 0x04000124 RID: 292
			public byte boneCount;
		}

		// Token: 0x0200002B RID: 43
		public struct DemoInfo
		{
			// Token: 0x04000125 RID: 293
			public int DemoDataPtr;

			// Token: 0x04000126 RID: 294
			public int DemoSize;
		}

		// Token: 0x0200002C RID: 44
		public class Settings
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600002C RID: 44 RVA: 0x0002F632 File Offset: 0x0002D832
			// (set) Token: 0x0600002D RID: 45 RVA: 0x0002F63A File Offset: 0x0002D83A
			public string cfg { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600002E RID: 46 RVA: 0x0002F643 File Offset: 0x0002D843
			// (set) Token: 0x0600002F RID: 47 RVA: 0x0002F64B File Offset: 0x0002D84B
			public string single { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000030 RID: 48 RVA: 0x0002F654 File Offset: 0x0002D854
			// (set) Token: 0x06000031 RID: 49 RVA: 0x0002F65C File Offset: 0x0002D85C
			public string fog { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000032 RID: 50 RVA: 0x0002F665 File Offset: 0x0002D865
			// (set) Token: 0x06000033 RID: 51 RVA: 0x0002F66D File Offset: 0x0002D86D
			public string ssao { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000034 RID: 52 RVA: 0x0002F676 File Offset: 0x0002D876
			// (set) Token: 0x06000035 RID: 53 RVA: 0x0002F67E File Offset: 0x0002D87E
			public string dof { get; set; }

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000036 RID: 54 RVA: 0x0002F687 File Offset: 0x0002D887
			// (set) Token: 0x06000037 RID: 55 RVA: 0x0002F68F File Offset: 0x0002D88F
			public string sun { get; set; }
		}
	}
}
