using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;

        public CarsController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        // GET api/values
        [HttpGet]
        public async Task<string> Get()
        {
            var client = _clientFactory.CreateClient();
            string response = await client.GetStringAsync("http://greetings-service/api/Greetings");
           
            return $"{response} from BMW";
        }
    }
}
