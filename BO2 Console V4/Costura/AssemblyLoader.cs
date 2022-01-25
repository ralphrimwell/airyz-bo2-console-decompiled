using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Costura
{
	// Token: 0x0200008C RID: 140
	[CompilerGenerated]
	internal static class AssemblyLoader
	{
		// Token: 0x06000276 RID: 630 RVA: 0x00051EAC File Offset: 0x000500AC
		private static string CultureToString(CultureInfo culture)
		{
			if (culture == null)
			{
				return "";
			}
			return culture.Name;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00051EC0 File Offset: 0x000500C0
		private static Assembly ReadExistingAssembly(AssemblyName name)
		{
			foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				AssemblyName name2 = assembly.GetName();
				if (string.Equals(name2.Name, name.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(AssemblyLoader.CultureToString(name2.CultureInfo), AssemblyLoader.CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					return assembly;
				}
			}
			return null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00051F28 File Offset: 0x00050128
		private static void CopyTo(Stream source, Stream destination)
		{
			byte[] array = new byte[81920];
			int count;
			while ((count = source.Read(array, 0, array.Length)) != 0)
			{
				destination.Write(array, 0, count);
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00051F5C File Offset: 0x0005015C
		private static Stream LoadStream(string fullName)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (fullName.EndsWith(".compressed"))
			{
				using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(fullName))
				{
					using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
					{
						MemoryStream memoryStream = new MemoryStream();
						AssemblyLoader.CopyTo(deflateStream, memoryStream);
						memoryStream.Position = 0L;
						return memoryStream;
					}
				}
			}
			return executingAssembly.GetManifestResourceStream(fullName);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00051FE0 File Offset: 0x000501E0
		private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
		{
			string fullName;
			if (resourceNames.TryGetValue(name, out fullName))
			{
				return AssemblyLoader.LoadStream(fullName);
			}
			return null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00052000 File Offset: 0x00050200
		private static byte[] ReadStream(Stream stream)
		{
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00052028 File Offset: 0x00050228
		private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
		{
			string text = requestedAssemblyName.Name.ToLowerInvariant();
			if (requestedAssemblyName.CultureInfo != null && !string.IsNullOrEmpty(requestedAssemblyName.CultureInfo.Name))
			{
				text = requestedAssemblyName.CultureInfo.Name + "." + text;
			}
			byte[] rawAssembly;
			using (Stream stream = AssemblyLoader.LoadStream(assemblyNames, text))
			{
				if (stream == null)
				{
					return null;
				}
				rawAssembly = AssemblyLoader.ReadStream(stream);
			}
			using (Stream stream2 = AssemblyLoader.LoadStream(symbolNames, text))
			{
				if (stream2 != null)
				{
					byte[] rawSymbolStore = AssemblyLoader.ReadStream(stream2);
					return Assembly.Load(rawAssembly, rawSymbolStore);
				}
			}
			return Assembly.Load(rawAssembly);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000520E8 File Offset: 0x000502E8
		public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
		{
			object obj = AssemblyLoader.nullCacheLock;
			lock (obj)
			{
				if (AssemblyLoader.nullCache.ContainsKey(e.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(e.Name);
			Assembly assembly = AssemblyLoader.ReadExistingAssembly(assemblyName);
			if (assembly != null)
			{
				return assembly;
			}
			assembly = AssemblyLoader.ReadFromEmbeddedResources(AssemblyLoader.assemblyNames, AssemblyLoader.symbolNames, assemblyName);
			if (assembly == null)
			{
				obj = AssemblyLoader.nullCacheLock;
				lock (obj)
				{
					AssemblyLoader.nullCache[e.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
				{
					assembly = Assembly.Load(assemblyName);
				}
			}
			return assembly;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000521C8 File Offset: 0x000503C8
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyLoader()
		{
			AssemblyLoader.assemblyNames.Add("asmdotnet", "costura.asmdotnet.dll.compressed");
			AssemblyLoader.symbolNames.Add("asmdotnet", "costura.asmdotnet.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("colorwheel.controls", "costura.colorwheel.controls.dll.compressed");
			AssemblyLoader.assemblyNames.Add("colorwheel.core", "costura.colorwheel.core.dll.compressed");
			AssemblyLoader.assemblyNames.Add("costura", "costura.costura.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.expression.prototyping.runtime", "costura.microsoft.expression.prototyping.runtime.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.toolkit.win32.ui.controls", "costura.microsoft.toolkit.win32.ui.controls.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.windowsapicodepack", "costura.microsoft.windowsapicodepack.dll.compressed");
			AssemblyLoader.symbolNames.Add("microsoft.windowsapicodepack", "costura.microsoft.windowsapicodepack.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.windowsapicodepack.shell", "costura.microsoft.windowsapicodepack.shell.dll.compressed");
			AssemblyLoader.symbolNames.Add("microsoft.windowsapicodepack.shell", "costura.microsoft.windowsapicodepack.shell.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.windowsapicodepack.shellextensions", "costura.microsoft.windowsapicodepack.shellextensions.dll.compressed");
			AssemblyLoader.symbolNames.Add("microsoft.windowsapicodepack.shellextensions", "costura.microsoft.windowsapicodepack.shellextensions.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
			AssemblyLoader.assemblyNames.Add("octokit", "costura.octokit.dll.compressed");
			AssemblyLoader.assemblyNames.Add("screenrecorderlib", "costura.screenrecorderlib.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.windows.controls.input.toolkit", "costura.system.windows.controls.input.toolkit.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.windows.interactivity", "costura.system.windows.interactivity.dll.compressed");
			AssemblyLoader.assemblyNames.Add("testplugin", "costura.testplugin.dll.compressed");
			AssemblyLoader.symbolNames.Add("testplugin", "costura.testplugin.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("wpfanimatedgif", "costura.wpfanimatedgif.dll.compressed");
			AssemblyLoader.symbolNames.Add("wpfanimatedgif", "costura.wpfanimatedgif.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("wpftoolkit", "costura.wpftoolkit.dll.compressed");
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000523C9 File Offset: 0x000505C9
		public static void Attach()
		{
			if (Interlocked.Exchange(ref AssemblyLoader.isAttached, 1) == 1)
			{
				return;
			}
			AppDomain.CurrentDomain.AssemblyResolve += AssemblyLoader.ResolveAssembly;
		}

		// Token: 0x04000419 RID: 1049
		private static object nullCacheLock = new object();

		// Token: 0x0400041A RID: 1050
		private static Dictionary<string, bool> nullCache = new Dictionary<string, bool>();

		// Token: 0x0400041B RID: 1051
		private static Dictionary<string, string> assemblyNames = new Dictionary<string, string>();

		// Token: 0x0400041C RID: 1052
		private static Dictionary<string, string> symbolNames = new Dictionary<string, string>();

		// Token: 0x0400041D RID: 1053
		private static int isAttached;
	}
}
