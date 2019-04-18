using Microsoft.AspNetCore.Mvc;

namespace GwrService.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "This Commute microservices \n" +
                   "Call \"/api/commute\"";
        }
    }
}