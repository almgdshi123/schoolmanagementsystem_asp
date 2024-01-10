using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.MvcWebUI.Controllers.TransportationDepartment
{
    public class TransportationDepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/pages/TransportationDepartment/TransportationDepartment.cshtml");
        }
    }
}
