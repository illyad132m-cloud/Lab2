using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_task_2
{
	public class Newspaper : LibraryItem
	{
		public Newspaper(string title) : base(title) { }
		public override void DisplayInfo()
		{
			Console.WriteLine($"Газета: '{Title}'");
		}
	}
}
