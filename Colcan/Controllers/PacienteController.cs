using Data.DataInterface;
using Dto.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Colcan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {

        private readonly IPaciente _ipaciente;

        public PacienteController(IPaciente paciente)
        {
            _ipaciente = paciente;
        }

        [HttpGet("GetPacientes")]
        public IActionResult GetPacientes()
        {
            try
            {
                return Ok(_ipaciente.GetPacientes());
            }
            catch (Exception ex)
            {
                return BadRequest("Error, comunicarse con soporte" + ex.Message);
            }
        }

        // GET api/<PacienteController>/5
        [HttpGet("GetPaciente")]
        public IActionResult GetPaciente([FromQuery] int id)
        {
            try
            {
                return Ok(_ipaciente.GetPacienteXId(id));
            }
            catch (Exception ex)
            {
                return BadRequest("Error, comunicarse con soporte" + ex.Message);
            }
        }

        // POST api/<PacienteController>
        [HttpPost]
        public IActionResult Post([FromBody] PacienteModel model)
        {
            try
            {
                return Ok(_ipaciente.InsertPaciente(model));
            }
            catch (Exception ex)
            {
                return BadRequest("Error, comunicarse con soporte" + ex.Message);
            }
        }

        // PUT api/<PacienteController>/5
        [HttpPut]
        public IActionResult Put([FromBody] PacienteModel model)
        {

            try
            {
                return Ok(_ipaciente.UpdatePaciente(model));
            }
            catch (Exception ex)
            {
                return BadRequest("Error, comunicarse con soporte" + ex.Message);
            }
        }

        // DELETE api/<PacienteController>/5
        [HttpDelete("Delete")]
        public IActionResult Delete([FromQuery]int id)
        {
            try
            {
                return Ok(_ipaciente.DeletePaciente(id));
            }
            catch (Exception ex)
            {
                return BadRequest("Error, comunicarse con soporte" + ex.Message);
            }
        }
    }
}
