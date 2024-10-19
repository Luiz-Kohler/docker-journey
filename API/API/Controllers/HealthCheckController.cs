using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : Controller
    {
        [HttpGet]
        public IActionResult IsOk()
        {
            return Ok(new { status = "^_-" });
        }

        [HttpGet("GetEnviroment")]
        public IActionResult GetEnviroment()
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            return Ok(new { env });
        }
    }
}
