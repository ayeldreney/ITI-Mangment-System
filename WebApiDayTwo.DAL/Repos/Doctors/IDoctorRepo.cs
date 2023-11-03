using WebApiDayTwo.DAL.Models;

namespace WebApiDayTwo.DAL.Repos.Doctors
{
    public interface IDoctorRepo
    {
        public Doctor? getDetailsById(int id);
        public IEnumerable<Doctor> GetAll();
        public IEnumerable<Doctor> GetAllByPerfomance(int performance);
        public bool AddDoctor(Doctor doctor);
        public int saveChanges();
        public void update(Doctor Entity);
        public Doctor? getDoctorById(int guid);

        public bool Delete(int id);


    }


}