using DigitalEducationServicec.Application.Features.Bus.Commands.Models;
using DigitalEducationServicec.Application.Features.Bus.Queries.Models;
using DigitalEducationServicec.Application.Features.Bus.Queries.Results;
using DigitalEducationServicec.MvcWebUI.Models;
using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DigitalEducationServicec.MvcWebUI.Controllers.TransportationDepartment.Bus
{
    public class BusController : Controller
    {
        private IMediator _mediatorInstance;

        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();

        public BusController()
        {
        }


        public async Task<IActionResult> Index()
        {
            var query = new GetBusListQuery();
            var BusOptions = await _mediator.Send(query);
            return View("~/Views/pages/TransportationDepartment/Bus/Bus.cshtml", BusOptions.Data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        { return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }); }
        [HttpGet]
        public async Task<IActionResult> Create()
        { return View("~/Views/pages/TransportationDepartment/Bus/Add_Bus.cshtml"); }


        public async Task<IActionResult> Create(AddBusCommand command)
        {
            if (ModelState.IsValid)
            {
                var classId = await _mediator.Send(command);
                TempData["message"] = "تم حفظ  بيانات السائق بنجاح";
                return RedirectToAction(nameof(Index));
            }
            var query = new GetBusListQuery();
            var BusOptions = await _mediator.Send(query);
            return View(command);
        }


        public async Task<IActionResult> Delete(DeleteBusCommand command)
        {
            if (ModelState.IsValid)
            {
                var classId = await _mediator.Send(command);
                TempData["error"] = "تم   حذف السائق بنجاح";
                return RedirectToAction(nameof(Index));
            }
            var query = new GetBusListQuery();
            var BusOptions = await _mediator.Send(query);
            return View(command);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            var query = new GetBusListQuery();
            var BusOptions = await _mediator.Send(query);
            ViewBag.BusOptions = BusOptions.Data.Find(x => x.BusId == id);
           
       

            return View("~/Views/pages/TransportationDepartment/Bus/Edit_Bus.cshtml", BusOptions.Data.Find(x => x.BusId == id));
        }

        public async Task<IActionResult> Edit(EditBusCommand command)
        {
            if (ModelState.IsValid)
            {
                var classId = await _mediator.Send(command);
                TempData["message"] = "تم تعديل  بيانات السائق بنجاح";
                return RedirectToAction(nameof(Index));
            }
            var query = new GetBusListQuery();
            var BusOptions = await _mediator.Send(query);
            return View(command);
        }
    }
}
