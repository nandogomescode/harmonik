//using Microsoft.AspNetCore.Components;
//using System.Web.Http;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace HarmonikWS_API.Controllers { 

    [ApiController]
    [Route("[controller]")]
    public class Harmonik : ControllerBase
    {

        [Route("Get1")]
        [HttpGet]
        public IActionResult Get1()
        {

            return Ok("Oie");

        }

    }

}
