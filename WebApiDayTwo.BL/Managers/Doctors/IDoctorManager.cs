using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiDayTwo.BL.Dtos.Doctors;

namespace WebApiDayTwo.BL.Managers.Doctors
{
    public interface IDoctorManager
    {
        public List<DoctorReadDtos> GetAllForCustomers();
        public bool AddDoctor(DoctorAddDto doctorAddDto);

        public bool Delete(int id);

        public bool UpdateDoctor(DoctorUpdateDto doctorDto);


    }
}
