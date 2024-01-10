using DigitalEducationServicec.Application.Features.AcademicSystems.Commands.Models;
using DigitalEducationServicec.Application.Features.AcademicSystems.Queries.Models;
using DigitalEducationServicec.MvcWebUI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DigitalEducationServicec.MvcWebUI.Controllers.SystemSetup.SetTuitionFees
{
    public class AcademicSystemsController : Controller
    {
        private IMediator _mediatorInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();


        public async Task<IActionResult> Index()
        {
            var query = new GetAcademicSystemsListQuery();
            var AcademicSystemsOptions = await _mediator.Send(query);
            return View("~/Views/Pages/SystemSetup/SetTuitionFees/AcademicSystems.cshtml", AcademicSystemsOptions.Data);

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Create(AddAcademicSystemCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["message"] = "تم حفظ  بيانات النظام بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetAcademicSystemsListQuery();
            var AcademicSystemsOptions = await _mediator.Send(query);
            return View(command);
        }



        public async Task<IActionResult> Delete(DeleteAcademicSystemCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["error"] = "تم   حذف النظام بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetAcademicSystemsListQuery();
            var AcademicSystemsOptions = await _mediator.Send(query);
            return View(command);
        }
        public async Task<IActionResult> Edit(EditAcademicSystemCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["message"] = "تم تعديل  بيانات النظام بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetAcademicSystemsListQuery();
            var AcademicSystemsOptions = await _mediator.Send(query);
            return View(command);
        }
    }
}

