using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.MvcWebUI.Controllers.SystemSetup
{
    public class SystemSetupController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/pages/SystemSetup/SystemSetup.cshtml");
        }
    }
}
