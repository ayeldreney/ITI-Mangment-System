using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiDayTwo.DAL.Models
{
    public class Doctor
    {

        public int Id { get; set; }    
        public string Name { get; set; }  =string .Empty;   
        public string Specialization { get; set; }= string.Empty;       
        public decimal Salary { get; set; }
        public int PrefomanceRate { get; set; }

        public virtual ICollection<Patient>? Patient { get; set; }      




    }
}
