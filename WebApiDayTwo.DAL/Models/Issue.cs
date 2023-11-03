﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiDayTwo.DAL.Models
{
    public class Issue
    {
        public int Id { get; set; } 
        public string Name { get; set; }=string.Empty;      

        public ICollection<Patient> Patients { get; set;} = new List<Patient>();
        

    }
}
