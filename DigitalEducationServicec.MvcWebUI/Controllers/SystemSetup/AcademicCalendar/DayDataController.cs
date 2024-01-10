using DigitalEducationServicec.Application.Features.DayData.Commands.Models;
using DigitalEducationServicec.Application.Features.DayData.Queries.Models;
using DigitalEducationServicec.Application.Features.Stage.Queries.Models;
using DigitalEducationServicec.MvcWebUI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DigitalEducationServicec.MvcWebUI.Controllers.SystemSetup.AcademicCalendar
{
    public class DayDataController : Controller
    {
        private IMediator _mediatorInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();




        public async Task<IActionResult> Index()
        {
            var query = new GetDayDataListQuery();
            var DayDataOptions = await _mediator.Send(query);
            return View("~/Views/pages/SystemSetup/AcademicCalendar/DayData.cshtml", DayDataOptions.Data);

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Create(AddDayDataCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["message"] = "تم حفظ  بيانات اليوم بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetDayDataListQuery();
            var DayDataOptions = await _mediator.Send(query);
            return View(command);
        }



        public async Task<IActionResult> Delete(DeleteDayDataCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["error"] = "تم   حذف اليوم بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetDayDataListQuery();
            var DayDataOptions = await _mediator.Send(query);
            return View(command);
        }
        public async Task<IActionResult> Edit(EditDayDataCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["message"] = "تم تعديل  بيانات اليوم بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetDayDataListQuery();
            var DayDataOptions = await _mediator.Send(query);
            return View(command);
        }
    }
}
