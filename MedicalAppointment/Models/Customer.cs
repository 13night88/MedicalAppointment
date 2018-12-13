using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAppointment.Models
{
	public class Customer : Person
	{
		public Customer(int id, string name)
			: base(id, name)
		{

		}
	}
}
