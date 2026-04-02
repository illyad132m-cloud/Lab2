using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_task_3
{
	public class Resolution
	{
		private int _width;
		private int _height;
		private const int minRes = 32;
		private const int maxRes = 16384;

		public int Width
		{
			get => _width;
			set => _width = Validate(value);
		}

		public int Height
		{
			get => _height;
			set => _height = Validate(value);
		}
		public Resolution(int width, int height)
		{
			Width = width;
			Height = height;
		}
		private static int	Validate(int val)
		{
			if (val < 32) return 32;
			if (val > 16384) return 16384;
			return val;
		}

		public static Resolution operator *(Resolution r, double f)
		{
			int newWidth = (int)(r.Width * f);
			int newHeight = (int)(r.Height * f);

			return new Resolution(newWidth, newHeight);
		}

		private long TotalPixels
		{
			get { return (long)_width * _height; }
		}
		public static bool operator >(Resolution r1, Resolution r2)
		{
			return r1.TotalPixels > r2.TotalPixels;
		}
		public static bool operator <(Resolution r1, Resolution r2)
		{
			return r1.TotalPixels < r2.TotalPixels;
		}
		public static bool operator ==(Resolution r1, Resolution r2)
		{
			return r1.TotalPixels == r2.TotalPixels;
		}
		public static bool operator !=(Resolution r1, Resolution r2)
		{
			return r1.TotalPixels != r2.TotalPixels;
		}
		public static Resolution operator +(Resolution r1, int offset)
		{
			return new Resolution(r1.Width + offset, r1.Height + offset);
		}
		public static Resolution operator -(Resolution r1, int offset)
		{
			return new Resolution(r1.Width - offset, r1.Height - offset);
		}
		public static Resolution operator /(Resolution r1, int divisor)
		{
			return new Resolution(r1.Width / divisor, r1.Height / divisor);
		}
		public static Resolution operator ~(Resolution r)
		{
			if (r.Width > r.Height)
			{
				return new Resolution(r.Height, r.Width);
			}
			else
			{
				return new Resolution(r.Width, r.Height);
			}
		}
		public static explicit operator double(Resolution r)
		{
			return (double)r.TotalPixels / 1_000_000.0;
		}

		public static explicit operator string(Resolution r)
		{
			int common = GetGcd(r.Width, r.Height);
			int ratioW = r.Width / common;
			int ratioH = r.Height / common;

			return ratioW + ":" + ratioH;
		}
		private static int GetGcd(int a, int b)
		{
			while (b != 0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}
		public override string ToString()
		{
			return Width + "x" + Height + " (" + TotalPixels + " px)";
		}
	}
}
