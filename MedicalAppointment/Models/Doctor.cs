using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAppointment.Models
{
	public class Doctor : Person
	{
		public Doctor(int id, string name)
			: base(id, name)
		{

		}
	}
}
