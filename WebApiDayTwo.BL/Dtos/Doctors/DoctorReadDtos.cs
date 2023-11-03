using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiDayTwo.BL.Dtos.Doctors
{
    public class DoctorReadDtos
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public int PrefomanceRate { get; set; }



    }
}
