using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BO2PluginFramework;

namespace BO2_Console_V4
{
	// Token: 0x0200000C RID: 12
	public class Dvars
	{
		// Token: 0x0200000D RID: 13
		public struct integerLimits
		{
			// Token: 0x04000074 RID: 116
			public int min;

			// Token: 0x04000075 RID: 117
			public int max;
		}

		// Token: 0x0200000E RID: 14
		public struct vectorLimits
		{
			// Token: 0x04000076 RID: 118
			public float min;

			// Token: 0x04000077 RID: 119
			public float max;
		}

		// Token: 0x0200000F RID: 15
		public struct integer64Limits
		{
			// Token: 0x04000078 RID: 120
			public long min;

			// Token: 0x04000079 RID: 121
			public long max;
		}

		// Token: 0x02000010 RID: 16
		[StructLayout(LayoutKind.Explicit)]
		public struct DvarLimits
		{
			// Token: 0x0400007A RID: 122
			[FieldOffset(0)]
			public Dvars.integerLimits integer;

			// Token: 0x0400007B RID: 123
			[FieldOffset(0)]
			public Dvars.vectorLimits vector;

			// Token: 0x0400007C RID: 124
			[FieldOffset(0)]
			public Dvars.integer64Limits integer64;
		}

		// Token: 0x02000011 RID: 17
		[StructLayout(LayoutKind.Explicit)]
		public struct DvarValue
		{
			// Token: 0x0400007D RID: 125
			[FieldOffset(0)]
			public bool enabled;

			// Token: 0x0400007E RID: 126
			[FieldOffset(0)]
			public int integer;

			// Token: 0x0400007F RID: 127
			[FieldOffset(0)]
			public uint unsignedInt;

			// Token: 0x04000080 RID: 128
			[FieldOffset(0)]
			public long integer64;

			// Token: 0x04000081 RID: 129
			[FieldOffset(0)]
			public ulong unsignedInt64;

			// Token: 0x04000082 RID: 130
			[FieldOffset(0)]
			public float value;

			// Token: 0x04000083 RID: 131
			[FieldOffset(0)]
			public Vector4 vector;

			// Token: 0x04000084 RID: 132
			[FieldOffset(0)]
			public int stringPointer;

			// Token: 0x04000085 RID: 133
			[FixedBuffer(typeof(byte), 4)]
			[FieldOffset(0)]
			public Dvars.DvarValue.<color>e__FixedBuffer color;

			// Token: 0x02000012 RID: 18
			[UnsafeValueType]
			[CompilerGenerated]
			[StructLayout(LayoutKind.Sequential, Size = 4)]
			public struct <color>e__FixedBuffer
			{
				// Token: 0x04000086 RID: 134
				public byte FixedElementField;
			}
		}

		// Token: 0x02000013 RID: 19
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		public struct dvar_t
		{
			// Token: 0x04000087 RID: 135
			public int namePointer;

			// Token: 0x04000088 RID: 136
			public int descriptionPointer;

			// Token: 0x04000089 RID: 137
			public int hash;

			// Token: 0x0400008A RID: 138
			public uint flags;

			// Token: 0x0400008B RID: 139
			public dvarType_t type;

			// Token: 0x0400008C RID: 140
			public bool modified;

			// Token: 0x0400008D RID: 141
			public Dvars.DvarValue current;

			// Token: 0x0400008E RID: 142
			public Dvars.DvarValue latched;

			// Token: 0x0400008F RID: 143
			public Dvars.DvarValue reset;

			// Token: 0x04000090 RID: 144
			public Dvars.DvarLimits domain;

			// Token: 0x04000091 RID: 145
			public int nextDvarPointer;

			// Token: 0x04000092 RID: 146
			public int unknown;
		}
	}
}
