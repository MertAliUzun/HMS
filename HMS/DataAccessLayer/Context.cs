using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Context: DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Secretary> Secretaries { get; set; }
        public DbSet<Pati> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

    }
}
