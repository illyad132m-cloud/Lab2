using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_task_2
{
	public class Librarian : Person
	{
		public Librarian(string name) : base(name) { }
		public void addBook(LibraryItem item, LibraryMember member)
		{
			if (item.isAvaliable == true)
			{
				item.isAvaliable = false;
				Console.WriteLine($"Бібліотекар {Name} видав '{item.Title}' читачу {member.Name}.");
			}
			else
			{
				Console.WriteLine($" '{item.Title}' немає в наявності");
			}
		}
		public void returnBook(LibraryItem item)
		{
			item.isAvaliable = true;
			Console.WriteLine($" '{item.Title}' повернуто до бібліотеки.");
		}
	}
}
