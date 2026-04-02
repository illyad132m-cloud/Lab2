using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_task_2
{
	public class Reservation
	{
		public LibraryItem Item { get; set; }
		public LibraryMember Member { get; set; }
		public DateTime Date { get; set; }
	}
}
