using System;
using System.Windows.Media;

namespace BO2_Console_V4.Classes
{
	// Token: 0x02000065 RID: 101
	public static class EmbedURLBuilder
	{
		// Token: 0x06000215 RID: 533 RVA: 0x0004F6EC File Offset: 0x0004D8EC
		public static string Youtube(string videoID, bool autoplay = false, int startTime = 0, int endTime = 0, bool muted = false)
		{
			string text = "https://www.youtube.com/embed/" + videoID;
			if (autoplay || startTime > 0 || endTime > 0)
			{
				text += "?";
			}
			if (autoplay)
			{
				text += "autoplay=1&";
			}
			if (startTime > 0)
			{
				text = text + "start=" + startTime.ToString() + "&";
			}
			if (endTime > 0)
			{
				text = text + "end= " + endTime.ToString() + "&";
			}
			if (muted)
			{
				text += "mute=1&";
			}
			return text;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0004F774 File Offset: 0x0004D974
		public static string Streamable(string videoID, SolidColorBrush col, int playerWidth, int playerHeight, bool autoplay = false, bool muted = false)
		{
			string text = string.Concat(new string[]
			{
				"<body bgcolor=\"#",
				col.ToString().Substring(3),
				"\"> <iframe class=\"streamable-embed\" src=\"https://streamable.com/o/",
				videoID,
				"?"
			});
			if (autoplay)
			{
				text += "autoplay=1&";
			}
			if (muted)
			{
				text += "muted=1&";
			}
			text = string.Concat(new string[]
			{
				text,
				"\" frameborder=\"0\" scrolling=\"no\" width=\"",
				(playerWidth - 20).ToString(),
				"\" height=\"",
				(playerHeight - 20).ToString(),
				"\" allowfullscreen></iframe>"
			});
			Console.WriteLine(text);
			return text;
		}
	}
}
