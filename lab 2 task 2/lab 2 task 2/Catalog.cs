using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_task_2
{
	public class Catalog
	{
		private List<LibraryItem> items = new List<LibraryItem>();
		public void AddItem(LibraryItem item)
		{
			items.Add(item);
		}
		public LibraryItem Search (string title)
		{
			foreach (LibraryItem items in items)
			{
				if (items.Title == title)
				{
					Console.WriteLine($"\nЗнайдено книгу: ");
					items.DisplayInfo();
					return items;
				}
			}
			Console.WriteLine($"\n '{title}' не знайдено.");
			return null;
		}
	}
}
