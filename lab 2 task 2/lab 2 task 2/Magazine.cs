using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_task_2
{
	public class Magazine : LibraryItem
	{
		public int Issue { get; set; } /// Issue - номер випуску журналу
		public Magazine(string title, int issue) : base(title)
		{
			Issue = issue;
		}
		public override void DisplayInfo()
		{
			Console.WriteLine($"Газета: '{Title}', Видання: {Issue}");
		}
	}
}