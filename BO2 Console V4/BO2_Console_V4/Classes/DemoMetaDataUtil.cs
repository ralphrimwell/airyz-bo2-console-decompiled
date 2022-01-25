using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BO2_Console_V4.Classes
{
	// Token: 0x0200005F RID: 95
	public static class DemoMetaDataUtil
	{
		// Token: 0x06000200 RID: 512 RVA: 0x0004F230 File Offset: 0x0004D430
		public static DemoMetaDataUtil.Map GetDemoMapName(string demo_tags_file)
		{
			DemoMetaDataUtil.Map map = (DemoMetaDataUtil.Map)File.ReadAllBytes(demo_tags_file)[33];
			Console.WriteLine(map.ToString());
			return (DemoMetaDataUtil.Map)File.ReadAllBytes(demo_tags_file)[33];
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0004F262 File Offset: 0x0004D462
		public static int FileMetaDataLength(byte[] filedata)
		{
			return BitConverter.ToInt32(filedata, filedata.Length - 8 - 4);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0004F271 File Offset: 0x0004D471
		public static int FileMetaDataLength(string filepath)
		{
			return DemoMetaDataUtil.FileMetaDataLength(File.ReadAllBytes(filepath));
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0004F27E File Offset: 0x0004D47E
		public static bool FileHasMetaData(string filepath)
		{
			return File.Exists(filepath) && DemoMetaDataUtil.FileHasMetaData(File.ReadAllBytes(filepath));
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0004F295 File Offset: 0x0004D495
		public static bool FileHasMetaData(byte[] filedata)
		{
			return BitConverter.ToInt64(filedata, filedata.Length - 8) == 1860853865228327281L;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0004F2B0 File Offset: 0x0004D4B0
		public static bool ApplyMetadataToDemoFile(string filepath, Dictionary<string, string> data)
		{
			bool result;
			try
			{
				string text = JsonConvert.SerializeObject(data);
				Console.WriteLine(text);
				byte[] bytes = Encoding.Unicode.GetBytes(text);
				byte[] array = File.ReadAllBytes(filepath);
				byte[] bytes2 = BitConverter.GetBytes(bytes.Length + 4 + 8);
				byte[] bytes3 = BitConverter.GetBytes(1860853865228327281L);
				if (DemoMetaDataUtil.FileHasMetaData(array))
				{
					int num = DemoMetaDataUtil.FileMetaDataLength(array);
					byte[] array2 = new byte[array.Length - num];
					Buffer.BlockCopy(array, 0, array2, 0, array.Length - num);
					File.WriteAllBytes(filepath, DemoMetaDataUtil.Combine(new byte[][]
					{
						array2,
						bytes,
						bytes2,
						bytes3
					}));
				}
				else
				{
					File.WriteAllBytes(filepath, DemoMetaDataUtil.Combine(new byte[][]
					{
						array,
						bytes,
						bytes2,
						bytes3
					}));
				}
				result = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occured while trying to write demo metadata: " + ex.GetType().ToString(), "Error:");
				result = false;
			}
			return result;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0004F3B0 File Offset: 0x0004D5B0
		public static Dictionary<string, string> ReadDemoMetaData(string filepath)
		{
			return DemoMetaDataUtil.ReadDemoMetaData(File.ReadAllBytes(filepath));
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0004F3C0 File Offset: 0x0004D5C0
		public static Dictionary<string, string> ReadDemoMetaData(byte[] filedata)
		{
			if (DemoMetaDataUtil.FileHasMetaData(filedata))
			{
				int num = DemoMetaDataUtil.FileMetaDataLength(filedata);
				int num2 = num - 4 - 8;
				byte[] array = new byte[num2];
				Buffer.BlockCopy(filedata, filedata.Length - num, array, 0, num2);
				string @string = Encoding.Unicode.GetString(array);
				Console.WriteLine(@string);
				return JsonConvert.DeserializeObject<Dictionary<string, string>>(@string);
			}
			return new Dictionary<string, string>();
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0004F414 File Offset: 0x0004D614
		private static byte[] Combine(params byte[][] arrays)
		{
			byte[] array = new byte[arrays.Sum((byte[] a) => a.Length)];
			int num = 0;
			foreach (byte[] array2 in arrays)
			{
				Buffer.BlockCopy(array2, 0, array, num, array2.Length);
				num += array2.Length;
			}
			return array;
		}

		// Token: 0x04000341 RID: 833
		public const int DEMO_DEFAULT_FOOTER = 13;

		// Token: 0x04000342 RID: 834
		public const long DEMO_METADATA_MAGIC = 1860853865228327281L;

		// Token: 0x02000060 RID: 96
		public enum Map
		{
			// Token: 0x04000344 RID: 836
			mp_la,
			// Token: 0x04000345 RID: 837
			mp_cargo,
			// Token: 0x04000346 RID: 838
			mp_carrier,
			// Token: 0x04000347 RID: 839
			mp_drone,
			// Token: 0x04000348 RID: 840
			mp_express,
			// Token: 0x04000349 RID: 841
			mp_hijacked,
			// Token: 0x0400034A RID: 842
			mp_meltdown,
			// Token: 0x0400034B RID: 843
			mp_overflow,
			// Token: 0x0400034C RID: 844
			mp_nightclub,
			// Token: 0x0400034D RID: 845
			mp_raid,
			// Token: 0x0400034E RID: 846
			mp_slums,
			// Token: 0x0400034F RID: 847
			mp_village,
			// Token: 0x04000350 RID: 848
			mp_turbine,
			// Token: 0x04000351 RID: 849
			mp_socotra,
			// Token: 0x04000352 RID: 850
			mp_nuketown_2020,
			// Token: 0x04000353 RID: 851
			mp_downhill,
			// Token: 0x04000354 RID: 852
			mp_mirage,
			// Token: 0x04000355 RID: 853
			mp_hydro,
			// Token: 0x04000356 RID: 854
			mp_skate,
			// Token: 0x04000357 RID: 855
			mp_concert,
			// Token: 0x04000358 RID: 856
			mp_magma,
			// Token: 0x04000359 RID: 857
			mp_vertigo,
			// Token: 0x0400035A RID: 858
			mp_studio,
			// Token: 0x0400035B RID: 859
			mp_uplink,
			// Token: 0x0400035C RID: 860
			mp_bridge,
			// Token: 0x0400035D RID: 861
			mp_castaway,
			// Token: 0x0400035E RID: 862
			mp_paintball,
			// Token: 0x0400035F RID: 863
			mp_dig,
			// Token: 0x04000360 RID: 864
			mp_frostbite,
			// Token: 0x04000361 RID: 865
			mp_pod,
			// Token: 0x04000362 RID: 866
			mp_takeoff
		}
	}
}
