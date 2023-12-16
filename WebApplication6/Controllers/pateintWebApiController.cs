using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pateintWebApiController : ControllerBase
    {
        Ipatient dbser;

        public pateintWebApiController(Ipatient dbser)
        {
            this.dbser = dbser;
        }
        [HttpGet]
        public IActionResult GetPatients()
        {
            try
            {
                var res = dbser.getAll();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddPatient(patient newRec)
        {
            try
            {
                dbser.AddPatient(newRec);
                return Ok("record added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeletePatient(int id)
        {
            try
            {
                dbser.DeletePatient(id);
                return Ok("record deleted");
            }
       
            catch(Exception ex)
            {
                return BadRequest(ex.Message); 
            }
    
}

        [HttpGet("GetById/{id}")]
        public IActionResult GetPatientById(int id)
        {
            try
            {
                var res = dbser.GetPatientById(id);
                return Ok(res);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdatePatient(patient upd)
        {
            try
            {
                dbser.UpdatePatient(upd);
                return Ok("record updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
