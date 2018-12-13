using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MedicalAppointment.Models
{
	public class MedicalRegistrationContext : DbContext
	{
		public DbSet<Customer> Customers { get; set; }

		public DbSet<Doctor> Doctors { get; set; }

		public DbSet<Manager> Managers { get; set; }
	}
}
