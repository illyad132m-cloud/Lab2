using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_task_2
{
	public class Book : LibraryItem
	{
		public string Author { get; set; }
		public Book (string title, string author) : base(title)
		{
			Author = author;
		}
		public override void DisplayInfo()
		{
			Console.WriteLine($"Книга: '{Title}', Автор: {Author}");
		}
	}
}
