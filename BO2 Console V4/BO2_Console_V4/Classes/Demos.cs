using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace BO2_Console_V4.Classes
{
	// Token: 0x02000062 RID: 98
	public static class Demos
	{
		// Token: 0x0600020C RID: 524 RVA: 0x0004F48C File Offset: 0x0004D68C
		private static void AddDemoToList(string mapName, string friendlyName, string filename, Dispatcher dispatcher)
		{
			dispatcher.Invoke(delegate()
			{
				Demos.DemoNameFileMap.Add(friendlyName, filename);
				if (Demos.DemosSortedByMap.ContainsKey(mapName))
				{
					Demos.DemosSortedByMap[mapName].Add(friendlyName);
					return;
				}
				Demos.DemosSortedByMap.Add(mapName, new ObservableCollection<string>
				{
					friendlyName
				});
				Demos.foundMaps.Add(mapName);
			});
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0004F4C8 File Offset: 0x0004D6C8
		private static string GetMapNameFromDemoFile(string filename)
		{
			string[] array = filename.Split(new char[]
			{
				'_'
			});
			return array[1] + "_" + array[2];
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0004F4F8 File Offset: 0x0004D6F8
		private static bool SearchDirectoryForDemos(DirectoryInfo info, Dispatcher dispatcher)
		{
			FileInfo[] files = info.GetFiles("*.demo");
			if (files.Length == 1)
			{
				string text = info.Name.Split(new string[]
				{
					" - "
				}, StringSplitOptions.None)[0];
				try
				{
					Demos.AddDemoToList(Demos.GetMapNameFromDemoFile(files[0].Name), info.Name, files[0].FullName, dispatcher);
					goto IL_5D;
				}
				catch
				{
					return false;
				}
			}
			int num = files.Length;
			IL_5D:
			using (IEnumerator<DirectoryInfo> enumerator = info.EnumerateDirectories().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!Demos.SearchDirectoryForDemos(enumerator.Current, dispatcher))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0004F5B8 File Offset: 0x0004D7B8
		public static void LoadDemos(string demos_folder, Dispatcher dispatcher)
		{
			Demos.DemosSortedByMap.Clear();
			Demos.DemoNameFileMap.Clear();
			Demos.foundMaps.Clear();
			if (!Demos.searching)
			{
				Task.Run(delegate()
				{
					Demos.searching = true;
					if (!Demos.SearchDirectoryForDemos(new DirectoryInfo(demos_folder), dispatcher))
					{
						MessageBox.Show("Error: Access was denied to some demo files...");
					}
					Demos.searching = false;
				});
			}
		}

		// Token: 0x04000365 RID: 869
		public static Dictionary<string, string> DemoNameFileMap = new Dictionary<string, string>();

		// Token: 0x04000366 RID: 870
		public static Dictionary<string, ObservableCollection<string>> DemosSortedByMap = new Dictionary<string, ObservableCollection<string>>();

		// Token: 0x04000367 RID: 871
		public static ObservableCollection<string> foundMaps = new ObservableCollection<string>();

		// Token: 0x04000368 RID: 872
		private static bool searching = false;

		// Token: 0x04000369 RID: 873
		private static Dictionary<string, int> data;
	}
}
