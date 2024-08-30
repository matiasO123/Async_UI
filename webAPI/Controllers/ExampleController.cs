using Microsoft.AspNetCore.Mvc;

namespace webAPI.Controllers
{
    [Route("example")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        [HttpGet("GetName/{name}")]     
        public ActionResult<string> GetName(string name)
        {
            return $"hello, {name}. Nice to meet you!!";
        }
    }
}
