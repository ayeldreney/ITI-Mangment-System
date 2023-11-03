using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiDayTwo.DAL.Models
{
    public class Patient
    {
       
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }

        public Doctor Doctor { get; set; } = null!;  

        public ICollection<Issue> Issues { get; set; } = new HashSet<Issue>();      

    }
}
