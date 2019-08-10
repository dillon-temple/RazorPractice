
using Microsoft.AspNetCore.Mvc;

namespace Portfolio
{

    public class HomeController : Controller
    {
        // Requests
        // localhost:5000/
        [HttpGet("")]
        public ViewResult RazorFun()
        {
            return View();
        }
    }
}