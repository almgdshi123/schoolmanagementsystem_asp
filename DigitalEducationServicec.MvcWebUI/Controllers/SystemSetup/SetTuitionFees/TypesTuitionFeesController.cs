using DigitalEducationServicec.Application.Features.TypesTuitionFees.Commands.Models;
using DigitalEducationServicec.Application.Features.TypesTuitionFees.Queries.Models;
using DigitalEducationServicec.MvcWebUI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DigitalEducationServicec.MvcWebUI.Controllers.SystemSetup.SetTuitionFees
{
    public class TypesTuitionFeesController : Controller
    {
        private IMediator _mediatorInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();

        public TypesTuitionFeesController()
        {

        }


        public async Task<IActionResult> Index()
        {
            var query = new GetTypesTuitionFeesListQuery();
            var TypesTuitionFeesOptions = await _mediator.Send(query);
            return View("~/Views/pages/SystemSetup/SetTuitionFees/TypesTuitionFees.cshtml", TypesTuitionFeesOptions.Data);

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Create(bool check, AddTypesTuitionFeesCommand command)
        {

            if (ModelState.IsValid)
            {
                command.Installments = check;

                var classId = await _mediator.Send(command);
                TempData["message"] = "تم حفظ  بيانات الرسوم بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetTypesTuitionFeesListQuery();
            var TypesTuitionFeesOptions = await _mediator.Send(query);
            return View(command);
        }



        public async Task<IActionResult> Delete(DeleteTypesTuitionFeesCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["error"] = "تم   حذف الرسوم بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetTypesTuitionFeesListQuery();
            var TypesTuitionFeesOptions = await _mediator.Send(query);
            return View(command);
        }
        public async Task<IActionResult> Edit(bool check, EditTypesTuitionFeesCommand command)
        {

            if (ModelState.IsValid)
            {
                command.Installments = check;
                var classId = await _mediator.Send(command);
                TempData["message"] = "تم تعديل  بيانات الرسوم بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetTypesTuitionFeesListQuery();
            var TypesTuitionFeesOptions = await _mediator.Send(query);
            return View(command);
        }
    }
}
