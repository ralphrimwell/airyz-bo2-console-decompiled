using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using Newtonsoft.Json;

namespace BO2_Console_V4.Classes
{
	// Token: 0x0200005A RID: 90
	public class Cache
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x0004EC54 File Offset: 0x0004CE54
		public void Save()
		{
			string text = JsonConvert.SerializeObject(this);
			File.WriteAllText("cache", Cache.Encrypt(text));
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0004EC78 File Offset: 0x0004CE78
		public static Cache LoadCacheFromFile()
		{
			Cache result;
			try
			{
				result = JsonConvert.DeserializeObject<Cache>(Cache.Decrypt(File.ReadAllText("cache")));
			}
			catch
			{
				result = new Cache();
			}
			return result;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0004ECB8 File Offset: 0x0004CEB8
		public void SetStreamableLogin(string username_raw, string password_raw)
		{
			string passPhrase = FingerPrint.Value("(jkfQ76&D<L]RSge_(zcsK;xB>8");
			this.streamable_username_encrypted = StringCipher.Encrypt(username_raw, passPhrase);
			this.streamable_password_encrypted = StringCipher.Encrypt(password_raw, passPhrase);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0004ECEC File Offset: 0x0004CEEC
		public string[] GetStreamableLogin()
		{
			if (this.streamable_password_encrypted != null && this.streamable_password_encrypted.Length > 0)
			{
				string[] array = new string[2];
				string passPhrase = FingerPrint.Value("(jkfQ76&D<L]RSge_(zcsK;xB>8");
				array[0] = StringCipher.Decrypt(this.streamable_username_encrypted, passPhrase);
				array[1] = StringCipher.Decrypt(this.streamable_password_encrypted, passPhrase);
				return array;
			}
			return new string[0];
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0004ED45 File Offset: 0x0004CF45
		private static string Encrypt(string text)
		{
			return StringCipher.Encrypt(StringCipher.Encrypt(StringCipher.Encrypt(text, "cg_fov_default"), "Hello, "), FingerPrint.Value(GetID.LastID()));
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0004ED6B File Offset: 0x0004CF6B
		private static string Decrypt(string ciphertext)
		{
			return StringCipher.Decrypt(StringCipher.Decrypt(StringCipher.Decrypt(ciphertext, FingerPrint.Value(GetID.LastID())), "Hello, "), "cg_fov_default");
		}

		// Token: 0x040002FC RID: 764
		public string Name;

		// Token: 0x040002FD RID: 765
		public string ID;

		// Token: 0x040002FE RID: 766
		public FontWeight fontWeight;

		// Token: 0x040002FF RID: 767
		public SolidColorBrush color = new SolidColorBrush(Color.FromArgb(byte.MaxValue, byte.MaxValue, 109, 0));

		// Token: 0x04000300 RID: 768
		public SolidColorBrush backgroundColor = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 20, 20, 20));

		// Token: 0x04000301 RID: 769
		public SolidColorBrush backgroundColorOpaque = new SolidColorBrush(Color.FromArgb(byte.MaxValue, 20, 20, 20));

		// Token: 0x04000302 RID: 770
		public float windowScale;

		// Token: 0x04000303 RID: 771
		public double fontSize;

		// Token: 0x04000304 RID: 772
		public bool darkTheme;

		// Token: 0x04000305 RID: 773
		public string theme;

		// Token: 0x04000306 RID: 774
		public AutoCompleteFilterMode filter;

		// Token: 0x04000307 RID: 775
		public int autocompleteLimit = -1;

		// Token: 0x04000308 RID: 776
		public List<string> enabledPlugins = new List<string>();

		// Token: 0x04000309 RID: 777
		public string demos_folder = "";

		// Token: 0x0400030A RID: 778
		public string streamable_username_encrypted = "";

		// Token: 0x0400030B RID: 779
		public string streamable_password_encrypted = "";

		// Token: 0x0400030C RID: 780
		public Dictionary<Keys, Keybind> Keybinds = new Dictionary<Keys, Keybind>();
	}
}
