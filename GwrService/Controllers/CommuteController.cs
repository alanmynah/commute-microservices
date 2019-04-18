using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GwrService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommuteController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "This is commute controller \n" +
                   "Call \"/commute/stations/{id}\" to get stations";
        }

        [HttpGet("stations/{id}")]
        public async Task <ActionResult<string>> Get(int id)
        {
            switch (id)
            {
                case 1:
                    return "Didcot";
                case 2:
                    return "Reading";
                default:
                    var httpClient = new HttpClient();
                    var requestUri = $"https://localhost:5011/paddington/{id}";
                    var result = await httpClient.GetAsync(requestUri);
                    return result.ToString();
            }
        }
    }
}