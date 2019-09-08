
using Microsoft.AspNetCore.Mvc;

namespace greetings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return $"Hello {AppInfo.Name}";
        }
    }
}
