using Microsoft.AspNetCore.Mvc;

namespace RoutingPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Home");
        }

        public IActionResult Privacy()
        {
            return Content("Privacy");
        }

        public IActionResult Display(string id)
        {
            if (id == null) {
                return Content("No ID supplied.");
            }
            else {
                return Content("ID: " + id);
            }
        }

        [Route("[action]/{start}/{end?}/{message?}")]
        public IActionResult Countdown(int start, int end = 0, string message = "")
        {
            string countString = "Counting down:\n";
            for (int i = start; i >= end; i--)
            {
                countString += i + "\n";
            }
            return Content(countString + message);
        }
    }
}