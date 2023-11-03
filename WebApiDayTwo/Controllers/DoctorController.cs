using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDayTwo.BL;
using WebApiDayTwo.BL.Dtos.Doctors;
using WebApiDayTwo.BL.Managers.Doctors;

namespace WebApiDayTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorManager _doctorManager; 

        public DoctorController(IDoctorManager manager)
        {
            _doctorManager=manager; 

        }


        [HttpDelete]
        public ActionResult Delete(int id) {

            _doctorManager.Delete(id);
        
            return NoContent(); 
        
        }    




        [HttpGet]
        public  ActionResult<List<DoctorReadDtos>> GetAll()=>
         _doctorManager.GetAllForCustomers();


        [HttpPost]
        public ActionResult Add(DoctorAddDto doctorAddDto) {

            _doctorManager.AddDoctor(doctorAddDto); 


            return StatusCode(StatusCodes.Status201Created);

        }

        [HttpPut]

        public ActionResult Update(DoctorUpdateDto doctorUpdateDto)
        {

            var result = _doctorManager.UpdateDoctor(doctorUpdateDto);

            if (!result)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return NoContent();

        }

    }
}
