using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BO2_Console_V4.Classes
{
	// Token: 0x0200005B RID: 91
	public static class StringCipher
	{
		// Token: 0x060001FA RID: 506 RVA: 0x0004EE38 File Offset: 0x0004D038
		public static string Encrypt(string plainText, string passPhrase)
		{
			byte[] array = StringCipher.Generate256BitsOfRandomEntropy();
			byte[] array2 = StringCipher.Generate256BitsOfRandomEntropy();
			byte[] bytes = Encoding.UTF8.GetBytes(plainText);
			string result;
			using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, array, 1000))
			{
				byte[] bytes2 = rfc2898DeriveBytes.GetBytes(32);
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					rijndaelManaged.BlockSize = 256;
					rijndaelManaged.Mode = CipherMode.CBC;
					rijndaelManaged.Padding = PaddingMode.PKCS7;
					using (ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(bytes2, array2))
					{
						using (MemoryStream memoryStream = new MemoryStream())
						{
							using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
							{
								cryptoStream.Write(bytes, 0, bytes.Length);
								cryptoStream.FlushFinalBlock();
								byte[] inArray = array.Concat(array2).ToArray<byte>().Concat(memoryStream.ToArray()).ToArray<byte>();
								memoryStream.Close();
								cryptoStream.Close();
								result = Convert.ToBase64String(inArray);
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0004EF7C File Offset: 0x0004D17C
		public static string Decrypt(string cipherText, string passPhrase)
		{
			byte[] array = Convert.FromBase64String(cipherText);
			byte[] salt = array.Take(32).ToArray<byte>();
			byte[] rgbIV = array.Skip(32).Take(32).ToArray<byte>();
			byte[] array2 = array.Skip(64).Take(array.Length - 64).ToArray<byte>();
			string @string;
			using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passPhrase, salt, 1000))
			{
				byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					rijndaelManaged.BlockSize = 256;
					rijndaelManaged.Mode = CipherMode.CBC;
					rijndaelManaged.Padding = PaddingMode.PKCS7;
					using (ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(bytes, rgbIV))
					{
						using (MemoryStream memoryStream = new MemoryStream(array2))
						{
							using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read))
							{
								byte[] array3 = new byte[array2.Length];
								int count = cryptoStream.Read(array3, 0, array3.Length);
								memoryStream.Close();
								cryptoStream.Close();
								@string = Encoding.UTF8.GetString(array3, 0, count);
							}
						}
					}
				}
			}
			return @string;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0004F0E4 File Offset: 0x0004D2E4
		private static byte[] Generate256BitsOfRandomEntropy()
		{
			byte[] array = new byte[32];
			using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
			{
				rngcryptoServiceProvider.GetBytes(array);
			}
			return array;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0004F124 File Offset: 0x0004D324
		public static string e(string text)
		{
			int num = 0;
			foreach (int num2 in text)
			{
				num += num2;
				if (num2 < 10)
				{
					num += 2;
					num *= num2;
				}
				else
				{
					num -= 20;
				}
			}
			return num.ToString();
		}

		// Token: 0x0400030D RID: 781
		private const int Keysize = 256;

		// Token: 0x0400030E RID: 782
		private const int DerivationIterations = 1000;
	}
}
