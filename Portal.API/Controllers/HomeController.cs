using Microsoft.AspNetCore.Mvc;

namespace Portal.API.Controllers
{
	public class HomeController : Controller
	{
        //https://localhost:5001/swagger/index.html
        [HttpGet("Test")]
        public IActionResult Index()
        {
            return Ok("swagger testi içindir");
        }
        
	}
}