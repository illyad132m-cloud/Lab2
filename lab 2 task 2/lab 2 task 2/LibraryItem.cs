using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_task_2
{
	public abstract class LibraryItem
	{
		public string Title { get; set; }
		public bool isAvaliable { get; set; }
		protected LibraryItem(string title)
		{
			Title = title;
		}
		public abstract void DisplayInfo();
	}
}
