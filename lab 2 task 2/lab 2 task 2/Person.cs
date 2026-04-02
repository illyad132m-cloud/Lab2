using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_task_2
{
	public abstract class Person
	{
		public string Name { get; set; }
		protected Person(string name)
		{
			Name = name;
		}
	}
}
