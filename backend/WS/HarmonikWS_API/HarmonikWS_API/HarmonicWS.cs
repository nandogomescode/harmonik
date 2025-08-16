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

        [Route("Get1")]
        [HttpGet]
        public IActionResult Get1()
        {

            Notes nt = new Notes();

            return Ok(nt.GetNotas());

        }

    }

}