using Microsoft.EntityFrameworkCore;
using WebApiDayTwo.DAL.Models;

namespace WebApiDayTwo.DAL.Data.Context
{
    public class HospitalContext:DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Issue> Issues { get; set; }
        public DbSet<Patient> Patients { get; set; }


        public HospitalContext(DbContextOptions options) : base(options) { 
        
        }


    





    }
}
