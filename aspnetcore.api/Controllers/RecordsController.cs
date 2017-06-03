using Microsoft.AspNetCore.Mvc;

namespace aspnetcore.api.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Get()
            => Content("Hello from API Controller") ;

    }
}
