using Microsoft.AspNetCore.Mvc;

namespace code_donor_weba_app.Controllers
{
    [Route("api/[controller]")]
    public class HealthController:ControllerBase
    {
        [HttpGet]
        public IActionResult Health()
        {
            return Ok("Healthy");
        }
    }
 }
