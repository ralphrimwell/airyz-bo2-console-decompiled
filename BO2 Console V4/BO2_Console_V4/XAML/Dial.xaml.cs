using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;

namespace BO2_Console_V4.XAML
{
	// Token: 0x02000050 RID: 80
	public partial class Dial : UserControl, INotifyPropertyChanged
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x000400EC File Offset: 0x0003E2EC
		public Dial()
		{
			this.InitializeComponent();
			base.DataContext = this;
			double alpha = (Math.Abs(this.Min) + this.Value) / (Math.Abs(this.Min) + Math.Abs(this.Max));
			this.Angle = this.Interpolate(0.0, 360.0, alpha);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00040165 File Offset: 0x0003E365
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x0004016D File Offset: 0x0003E36D
		public double Angle
		{
			get
			{
				return this.m_angle;
			}
			set
			{
				this.SetProperty<double>(ref this.m_angle, value, "Angle");
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00040181 File Offset: 0x0003E381
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00040194 File Offset: 0x0003E394
		public double Value
		{
			get
			{
				return (double)base.GetValue(Dial.ValueProperty);
			}
			set
			{
				double num = (Math.Abs(this.Min) + value) / (Math.Abs(this.Min) + Math.Abs(this.Max));
				this.Angle = this.Interpolate(0.0, 360.0, (num - this.alphaoffset) % 1.0);
				base.SetValue(Dial.ValueProperty, value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00040208 File Offset: 0x0003E408
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x0004021A File Offset: 0x0003E41A
		public double Min
		{
			get
			{
				return (double)base.GetValue(Dial.MinProperty);
			}
			set
			{
				base.SetValue(Dial.MinProperty, value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0004022D File Offset: 0x0003E42D
		// (set) Token: 0x060001DB RID: 475 RVA: 0x0004023F File Offset: 0x0003E43F
		public double Max
		{
			get
			{
				return (double)base.GetValue(Dial.MaxProperty);
			}
			set
			{
				base.SetValue(Dial.MaxProperty, value);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001DC RID: 476 RVA: 0x00040254 File Offset: 0x0003E454
		// (remove) Token: 0x060001DD RID: 477 RVA: 0x0004028C File Offset: 0x0003E48C
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060001DE RID: 478 RVA: 0x000402C4 File Offset: 0x0003E4C4
		// (remove) Token: 0x060001DF RID: 479 RVA: 0x000402FC File Offset: 0x0003E4FC
		public event EventHandler ValueChanged;

		// Token: 0x060001E0 RID: 480 RVA: 0x00040331 File Offset: 0x0003E531
		private void SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
		{
			if (!object.Equals(storage, value))
			{
				storage = value;
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00040364 File Offset: 0x0003E564
		private double Interpolate(double start, double end, double alpha)
		{
			double result = 0.0;
			if (start > end)
			{
				double num = start - end;
				double num2 = alpha * num;
				return start - num2;
			}
			if (end > start)
			{
				double num3 = end - start;
				return alpha * num3 + start;
			}
			return result;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0004039C File Offset: 0x0003E59C
		private double getAngle(Point clickPoint, Size circleSize)
		{
			double num = circleSize.Width / 2.0;
			double num2 = circleSize.Height / 2.0;
			return Math.Atan2(clickPoint.Y - num2, clickPoint.X - num) * 180.0 / 3.141592653589793 + 90.0;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00040404 File Offset: 0x0003E604
		private void MyThumb_DragDelta(object sender, DragDeltaEventArgs e)
		{
			double num = this.getAngle(Mouse.GetPosition(this), base.RenderSize) / 360.0;
			if (num < 0.0)
			{
				num = 1.0 + num;
			}
			num = (num + this.alphaoffset) % 1.0;
			this.Value = this.Interpolate(this.Min, this.Max, num);
			EventHandler valueChanged = this.ValueChanged;
			if (valueChanged == null)
			{
				return;
			}
			valueChanged(this, new EventArgs());
		}

		// Token: 0x040002B7 RID: 695
		private double alphaoffset = 0.75;

		// Token: 0x040002B8 RID: 696
		private double m_angle;

		// Token: 0x040002B9 RID: 697
		public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(double), typeof(Dial), new PropertyMetadata(0.0));

		// Token: 0x040002BA RID: 698
		public static DependencyProperty MinProperty = DependencyProperty.Register("Min", typeof(double), typeof(Dial), new PropertyMetadata(0.0));

		// Token: 0x040002BB RID: 699
		public static DependencyProperty MaxProperty = DependencyProperty.Register("Max", typeof(double), typeof(Dial), new PropertyMetadata(360.0));
	}
}
