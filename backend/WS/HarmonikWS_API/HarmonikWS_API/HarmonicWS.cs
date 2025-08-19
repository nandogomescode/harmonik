using Microsoft.AspNetCore.Mvc;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using HarmonicServices;

namespace HarmonikWS_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HarmonikWS : ControllerBase
    {

        [Route("GetNotas")]
        [HttpGet]
        public IActionResult GetNotas()
        {

            Notes nt = new Notes();

            return Ok(nt.GetNotas());

        }

        [Route("GetNota")]
        [HttpGet]
        public IActionResult GetNota()
        {


            return Ok(0);


        }

        [Route("GetHarmonicProgression")]
        [HttpGet]
        public IActionResult GetHarmonicProgression()
        {



            return Ok(0);

        }

    }

}