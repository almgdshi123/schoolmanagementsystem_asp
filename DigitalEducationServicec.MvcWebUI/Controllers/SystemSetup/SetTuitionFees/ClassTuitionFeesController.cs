using DigitalEducationServicec.Application.Features.ClassData.Queries.Models;
using DigitalEducationServicec.Application.Features.ClassTuitionFees.Commands.Models;
using DigitalEducationServicec.Application.Features.ClassTuitionFees.Queries.Models;
using DigitalEducationServicec.Application.Features.Stage.Queries.Models;
using DigitalEducationServicec.Application.Features.TypesTuitionFees.Queries.Models;
using DigitalEducationServicec.MvcWebUI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DigitalEducationServicec.MvcWebUI.Controllers.SystemSetup.SetTuitionFees
{
    public class ClassTuitionFeesController : Controller
    {
        private IMediator _mediatorInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();


        public async Task<IActionResult> Index()
        {
            var query = new GetClassTuitionFeesListQuery();
            var ClassTuitionFeesOptions = await _mediator.Send(query);
            var ClassDataOptions = await _mediator.Send(new GetClassDataListQuery());
          
            var TypesTuitionFeesOptions = await _mediator.Send(new GetTypesTuitionFeesListQuery());

            ViewBag.Class = ClassDataOptions.Data;
            ViewBag.TypesTuition = TypesTuitionFeesOptions.Data;

            return View("~/Views/Pages/SystemSetup/SetTuitionFees/ClassTuitionFees.cshtml", ClassTuitionFeesOptions.Data);

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Create(AddClassTuitionFeesCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["message"] = "تم حفظ  بيانات الرسوم بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetClassTuitionFeesListQuery();
            var ClassTuitionFeesOptions = await _mediator.Send(query);
            return View(command);
        }



        public async Task<IActionResult> Delete(DeleteClassTuitionFeesCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["error"] = "تم   حذف الرسوم بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetClassTuitionFeesListQuery();
            var ClassTuitionFeesOptions = await _mediator.Send(query);
            return View(command);
        }
        public async Task<IActionResult> Edit(EditClassTuitionFeesCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["message"] = "تم تعديل  بيانات الرسوم بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetClassTuitionFeesListQuery();
            var ClassTuitionFeesOptions = await _mediator.Send(query);
            return View(command);
        }
    }
}
