using Microsoft.AspNetCore.Mvc;

namespace hello_world
{
    [Route("/api/[controller]")]
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Greetings()
        {
            return Ok("Heyyyyyy everybodyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy My name is Boby Cheeka");
        }
    }
}