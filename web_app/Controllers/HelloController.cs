
using Microsoft.AspNetCore.Mvc;

namespace web_app.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("<h1>Hello World!</h1>", "text/html");
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
