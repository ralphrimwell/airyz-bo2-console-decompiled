using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using BO2PluginFramework;

namespace BO2_Console_V4.Classes
{
	// Token: 0x0200006E RID: 110
	internal class PluginLoader
	{
		// Token: 0x06000239 RID: 569 RVA: 0x0004FFF4 File Offset: 0x0004E1F4
		private static string CalculateMD5(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					result = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00050064 File Offset: 0x0004E264
		public static ICollection<PluginLoader.Plugin> LoadPlugins(string path)
		{
			if (Directory.Exists(path))
			{
				string[] files = Directory.GetFiles(path, "*.dll");
				Type typeFromHandle = typeof(IBO2Plugin);
				new List<Type>();
				new List<Assembly>(files.Length);
				ICollection<PluginLoader.Plugin> collection = new List<PluginLoader.Plugin>();
				foreach (string text in files)
				{
					Assembly assembly = Assembly.Load(AssemblyName.GetAssemblyName(text));
					if (assembly != null)
					{
						foreach (Type type in assembly.GetTypes())
						{
							if (!type.IsInterface && !type.IsAbstract && type.GetInterface(typeFromHandle.FullName) != null)
							{
								IBO2Plugin plugin = (IBO2Plugin)Activator.CreateInstance(type);
								collection.Add(new PluginLoader.Plugin
								{
									plugin = plugin,
									hash = PluginLoader.CalculateMD5(text)
								});
							}
						}
					}
				}
				return collection;
			}
			return null;
		}

		// Token: 0x0200006F RID: 111
		public struct Plugin
		{
			// Token: 0x0600023C RID: 572 RVA: 0x0005015B File Offset: 0x0004E35B
			public override string ToString()
			{
				return this.plugin.Name;
			}

			// Token: 0x0400038E RID: 910
			public IBO2Plugin plugin;

			// Token: 0x0400038F RID: 911
			public string hash;
		}
	}
}
