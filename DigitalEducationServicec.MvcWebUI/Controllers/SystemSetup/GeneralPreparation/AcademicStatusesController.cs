using DigitalEducationServicec.Application.Features.AcademicStatuses.Queries.Models;
using DigitalEducationServicec.Application.Features.AcademicStatuses.Commands.Models;
using DigitalEducationServicec.MvcWebUI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.MvcWebUI.Controllers.SystemSetup.GeneralPreparation
{
    public class AcademicStatusesController : Controller
    {
        private IMediator _mediatorInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();

        public AcademicStatusesController()
        {
                
        }
 

        public async Task<IActionResult> Index()
        {
            var query = new GetAcademicStatusesListQuery();
            var AcademicStatusesOptions = await _mediator.Send(query);
            return View("~/Views/Pages/SystemSetup/GeneralPreparations/AcademicStatuses.cshtml", AcademicStatusesOptions.Data) ;

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Create(AddAcademicStatusCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["message"] = "تم حفظ  بيانات الحالة بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetAcademicStatusesListQuery();
            var AcademicStatusesOptions = await _mediator.Send(query);
            return View(command);
        }



        public async Task<IActionResult> Delete(DeleteAcademicStatusCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["error"] = "تم   حذف الحالة بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetAcademicStatusesListQuery();
            var AcademicStatusesOptions = await _mediator.Send(query);
            return View(command);
        }
        public async Task<IActionResult> Edit(EditAcademicStatusCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["message"] = "تم تعديل  بيانات الحالة بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetAcademicStatusesListQuery();
            var AcademicStatusesOptions = await _mediator.Send(query);
            return View(command);
        }
    }
}
