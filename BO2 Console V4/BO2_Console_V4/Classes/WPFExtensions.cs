using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace BO2_Console_V4.Classes
{
	// Token: 0x0200007D RID: 125
	public static class WPFExtensions
	{
		// Token: 0x06000260 RID: 608 RVA: 0x0005127D File Offset: 0x0004F47D
		public static IEnumerable<Visual> GetChildren(this Visual parent, bool recurse = true)
		{
			if (parent != null)
			{
				int count = VisualTreeHelper.GetChildrenCount(parent);
				int num;
				for (int i = 0; i < count; i = num + 1)
				{
					Visual child = VisualTreeHelper.GetChild(parent, i) as Visual;
					if (child != null)
					{
						yield return child;
						if (recurse)
						{
							foreach (Visual visual in child.GetChildren(true))
							{
								yield return visual;
							}
							IEnumerator<Visual> enumerator = null;
						}
					}
					child = null;
					num = i;
				}
			}
			yield break;
			yield break;
		}
	}
}
