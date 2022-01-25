using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BO2_Console_V4.Classes
{
	// Token: 0x02000070 RID: 112
	internal static class StreamableAPI
	{
		// Token: 0x0600023D RID: 573 RVA: 0x00050168 File Offset: 0x0004E368
		private static Task UploadInternal(string Username, string Password, byte[] data, string name, Func<string, bool> callback)
		{
			StreamableAPI.<UploadInternal>d__0 <UploadInternal>d__;
			<UploadInternal>d__.Username = Username;
			<UploadInternal>d__.Password = Password;
			<UploadInternal>d__.data = data;
			<UploadInternal>d__.name = name;
			<UploadInternal>d__.callback = callback;
			<UploadInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UploadInternal>d__.<>1__state = -1;
			<UploadInternal>d__.<>t__builder.Start<StreamableAPI.<UploadInternal>d__0>(ref <UploadInternal>d__);
			return <UploadInternal>d__.<>t__builder.Task;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000501CC File Offset: 0x0004E3CC
		private static Task TestLoginInternal(string Username, string Password, Func<bool, bool> callback)
		{
			StreamableAPI.<TestLoginInternal>d__1 <TestLoginInternal>d__;
			<TestLoginInternal>d__.Username = Username;
			<TestLoginInternal>d__.Password = Password;
			<TestLoginInternal>d__.callback = callback;
			<TestLoginInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<TestLoginInternal>d__.<>1__state = -1;
			<TestLoginInternal>d__.<>t__builder.Start<StreamableAPI.<TestLoginInternal>d__1>(ref <TestLoginInternal>d__);
			return <TestLoginInternal>d__.<>t__builder.Task;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0005021F File Offset: 0x0004E41F
		public static void UploadVideo(string username, string password, string filepath, Func<string, bool> callback)
		{
			StreamableAPI.<>c__DisplayClass2_0 CS$<>8__locals1 = new StreamableAPI.<>c__DisplayClass2_0();
			CS$<>8__locals1.username = username;
			CS$<>8__locals1.password = password;
			CS$<>8__locals1.filepath = filepath;
			CS$<>8__locals1.callback = callback;
			Task.Run(delegate()
			{
				StreamableAPI.<>c__DisplayClass2_0.<<UploadVideo>b__0>d <<UploadVideo>b__0>d;
				<<UploadVideo>b__0>d.<>4__this = CS$<>8__locals1;
				<<UploadVideo>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<UploadVideo>b__0>d.<>1__state = -1;
				<<UploadVideo>b__0>d.<>t__builder.Start<StreamableAPI.<>c__DisplayClass2_0.<<UploadVideo>b__0>d>(ref <<UploadVideo>b__0>d);
				return <<UploadVideo>b__0>d.<>t__builder.Task;
			});
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00050253 File Offset: 0x0004E453
		public static void UploadVideo(string username, string password, byte[] data, string name, Func<string, bool> callback)
		{
			StreamableAPI.<>c__DisplayClass3_0 CS$<>8__locals1 = new StreamableAPI.<>c__DisplayClass3_0();
			CS$<>8__locals1.username = username;
			CS$<>8__locals1.password = password;
			CS$<>8__locals1.data = data;
			CS$<>8__locals1.name = name;
			CS$<>8__locals1.callback = callback;
			Task.Run(delegate()
			{
				StreamableAPI.<>c__DisplayClass3_0.<<UploadVideo>b__0>d <<UploadVideo>b__0>d;
				<<UploadVideo>b__0>d.<>4__this = CS$<>8__locals1;
				<<UploadVideo>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<UploadVideo>b__0>d.<>1__state = -1;
				<<UploadVideo>b__0>d.<>t__builder.Start<StreamableAPI.<>c__DisplayClass3_0.<<UploadVideo>b__0>d>(ref <<UploadVideo>b__0>d);
				return <<UploadVideo>b__0>d.<>t__builder.Task;
			});
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0005028F File Offset: 0x0004E48F
		public static void TestLogin(string username, string password, Func<bool, bool> callback)
		{
			StreamableAPI.<>c__DisplayClass4_0 CS$<>8__locals1 = new StreamableAPI.<>c__DisplayClass4_0();
			CS$<>8__locals1.username = username;
			CS$<>8__locals1.password = password;
			CS$<>8__locals1.callback = callback;
			Task.Run(delegate()
			{
				StreamableAPI.<>c__DisplayClass4_0.<<TestLogin>b__0>d <<TestLogin>b__0>d;
				<<TestLogin>b__0>d.<>4__this = CS$<>8__locals1;
				<<TestLogin>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<TestLogin>b__0>d.<>1__state = -1;
				<<TestLogin>b__0>d.<>t__builder.Start<StreamableAPI.<>c__DisplayClass4_0.<<TestLogin>b__0>d>(ref <<TestLogin>b__0>d);
				return <<TestLogin>b__0>d.<>t__builder.Task;
			});
		}
	}
}
