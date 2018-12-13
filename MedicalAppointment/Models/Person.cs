using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAppointment.Models
{
	public class Person
	{
		public int PersonId { get; set; }
		public string Name;

		public Person(int id, string name)
		{
			PersonId = id;
			Name = name;
		}
	}
}
