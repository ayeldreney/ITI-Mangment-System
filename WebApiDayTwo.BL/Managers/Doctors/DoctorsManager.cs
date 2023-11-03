using System;


using System.Text;
using WebApiDayTwo.BL.Dtos.Doctors;
using WebApiDayTwo.BL.Managers.Doctors;
using WebApiDayTwo.DAL.Models;
using WebApiDayTwo.DAL.Repos.Doctors;

namespace WebApiDayTwo.BL
{
    public class DoctorsManager: IDoctorManager
    {
        private readonly IDoctorRepo _doctorsRepo;    

        public DoctorsManager(IDoctorRepo doctorRepo)
        {
            this._doctorsRepo = doctorRepo;
        }



        public object getDetailsById() {
            
            
            


            return null!;
        }





        public bool Delete(int id) {

            _doctorsRepo.Delete(id);
            return true;
        }




        public List<DoctorReadDtos> GetAllForCustomers() {

            var dbDoctor = _doctorsRepo.GetAll().Select(x => new DoctorReadDtos() {Id=x.Id,Name=x.Name,Specialization=x.Specialization,PrefomanceRate=x.PrefomanceRate }).ToList(); 

            return dbDoctor;
        }


        public bool AddDoctor(DoctorAddDto doctorAddDto) {

            Doctor doctor = new Doctor()
            {
                 
                Name=doctorAddDto.Name, 
                Specialization=doctorAddDto.Specialization, 
                Salary=doctorAddDto.Salary, 
            };   

            _doctorsRepo.AddDoctor(doctor); 
            _doctorsRepo.saveChanges();
            return true;
        }


        public bool UpdateDoctor(DoctorUpdateDto doctorDto) {

            Doctor? doctorUpdated = _doctorsRepo.getDoctorById(doctorDto.Id);

            if (doctorUpdated == null) return false;
            

            doctorUpdated.Name= doctorDto.Name; 
            doctorUpdated.Specialization= doctorDto.Specialization;
            doctorUpdated.Salary= doctorDto.Salary;   


       
            _doctorsRepo.update(doctorUpdated);
            _doctorsRepo.saveChanges();
            return true;     


        }


          

    }
}
