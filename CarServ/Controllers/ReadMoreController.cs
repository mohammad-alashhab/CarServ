using Microsoft.AspNetCore.Mvc;

namespace CarServ.Controllers
{
    public class ReadMoreController : Controller
    {
        /*
            /ReadMore/DiagnosticTest
            /ReadMore/EngineServicing
            /ReadMore/TiresReplacement
            /ReadMore/OilChanging
         
         
         
         */
        public IActionResult DiagnosticTest()
        {
            return View();
        }
        public IActionResult EngineServicing()
        {
            return View();
        }
        public IActionResult TiresReplacement()
        {
            return View();
        }
        public IActionResult OilChanging()
        {
            return View();
        }
    }
}
