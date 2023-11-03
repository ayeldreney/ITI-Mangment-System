using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiDayTwo.DAL.Data.Context;
using WebApiDayTwo.DAL.Models;

namespace WebApiDayTwo.DAL.Repos.Doctors
{
    public class DoctorsRepo:IDoctorRepo
    {
        private readonly HospitalContext _context;

        public DoctorsRepo(HospitalContext Context)
        {
            this._context = Context;
        }



        public Doctor? getDetailsById(int id) =>
             _context.Set<Doctor>().Include(p => p.Patient).ThenInclude(i => i.Issues).FirstOrDefault(p=>p.Id==id); 
 
       
        




        public Doctor? getDoctorById(int guid) {

            var doctorTobeFound = _context.Set<Doctor>().FirstOrDefault(f => f.Id == guid);
            return doctorTobeFound;

         /*   var doctorTobeFound = _context.Set<Doctor>().AsNoTracking().FirstOrDefault(f => f.Id == guid);

            return doctorTobeFound;*/

        }



        public bool Delete(int id) {

            Doctor? found = getDoctorById(id);
            _context.Set<Doctor>().Remove(found);  
            saveChanges();
            return true;

        }



        public bool AddDoctor(Doctor doctor)
        {
            _context.Set<Doctor>().Add(doctor); 
            saveChanges();
            return true;    

        }

        public IEnumerable<Doctor> GetAll()
        {
            IEnumerable<Doctor> result = _context.Set<Doctor>().AsNoTracking().ToList();

            if (result == null)
            {
                return Enumerable.Empty<Doctor>();  
            }
            return result;
        }



        public IEnumerable<Doctor> GetAllByPerfomance(int performance) {
            return _context.Set<Doctor>().Where(f => f.PrefomanceRate >= performance).ToList();  
     
        }





        public int saveChanges() { 
        return _context.SaveChanges();
        }


        public void update(Doctor Entity) {
             _context.Set<Doctor>().Update(Entity);
        }

    }
}
