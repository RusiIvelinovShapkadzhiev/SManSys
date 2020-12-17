using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get() 
        {
            return "Hello world!";
        }

    }
}