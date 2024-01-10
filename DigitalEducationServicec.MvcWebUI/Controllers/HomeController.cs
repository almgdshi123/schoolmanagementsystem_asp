using DigitalEducationServicec.Application.Features.ClassData.Commands.Models;
using DigitalEducationServicec.Application.Features.Stage.Queries.Models;
using DigitalEducationServicec.MvcWebUI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace DigitalEducationServicec.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        private IMediator _mediatorInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Create(AddClassDataCommand command)
        {
            if (ModelState.IsValid)
            {
                var classId = await _mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }
            var query = new GetStageListQuery();
            var stageOptions = await _mediator.Send(query);
            ViewBag.StageOptions = stageOptions.Data.Select(s => new SelectListItem { Value = s.StageId.ToString(), Text = s.StageName }).ToList(); ;
            return View(command);
        }
        public async Task<IActionResult> Create()
        {

            var query = new GetStageListQuery();
            var stageOptions = await _mediator.Send(query);
            ViewBag.StageOptions = stageOptions.Data.Select(s => new SelectListItem { Value = s.StageId.ToString(), Text = s.StageName }).ToList(); ;
            return View();
        }
        [Route("Dashboard")]
        public IActionResult Dashboard()
        {

            return View("~/Views/Pages/Dashboard/Dashboard.cshtml");
        }
    }
}


//        public HomeController(ILogger<HomeController> logger)
//        {
//            _logger = logger;
//        }
//        [HttpPost]
//       
//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}