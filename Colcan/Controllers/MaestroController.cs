using Data.DataInterface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Colcan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaestroController : ControllerBase
    {
        private readonly IMaestro _iMaestro;

        public MaestroController(IMaestro maestro)
        {
           _iMaestro = maestro;
        }


        [HttpGet("GetGeneros")]
        public IActionResult GetGeneros()
        {
            try
            {
                return Ok(_iMaestro.GetGeneros());
            }
            catch (Exception ex)
            {
                return BadRequest("Error, comunicarse con soporte" + ex.Message);
            }
        }

        [HttpGet("GetTiposDocumentos")]
        public IActionResult GetTiposDocumentos()
        {
            try
            {
                return Ok(_iMaestro.GetTiposDocumentos());
            }
            catch (Exception ex)
            {
                return BadRequest("Error, comunicarse con soporte" + ex.Message);
            }
        }
 
        [HttpGet("GetTiposSubRed")]
        public IActionResult GetTiposSubRed()
        {
            try
            {
                return Ok(_iMaestro.GetTiposSubRed());
            }
            catch (Exception ex)
            {
                return BadRequest("Error, comunicarse con soporte" + ex.Message);
            }
        }

    }
}
