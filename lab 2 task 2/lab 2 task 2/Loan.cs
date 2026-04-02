using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace lab_2_task_2
{
	public class Loan
	{
		public LibraryItem Item { get; set; }
		public LibraryMember Member { get; set; }

		public DateTime DueDate { get; set; }
		public DateTime? ReturnDate { get; set; } /// ? - це тип nullable, який дозволяє значенню бути порожнім
		public void CheckStatus()
		{
			if (ReturnDate == null && DateTime.Now > DueDate)
			{
				Console.WriteLine($"{Member.Name} прострочив здачу '{Item.Title}'!");
			}
			else if (ReturnDate > DueDate)
			{
				Console.WriteLine($" {Member.Name} здав '{Item.Title}' із запізненням!");
			}
			else 
			{
				Console.WriteLine($" З книгою '{Item.Title}' все в порядку.");
			}
		}
	}
}

