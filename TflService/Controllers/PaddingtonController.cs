using Microsoft.AspNetCore.Mvc;

namespace TflService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaddingtonController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return id == 3 ? "Paddington" : "Other stations";
        }
    }
}