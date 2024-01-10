using DigitalEducationServicec.Application.Features.Stage.Commands.Models;
using MediatR;
using DigitalEducationServicec.Domain.AppMetaData;

using Microsoft.AspNetCore.Mvc;
using DigitalEducationServicec.Application.Features.ClassData.Commands.Models;
using DigitalEducationServicec.Application.Features.Stage.Queries.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using DigitalEducationServicec.MvcWebUI.Models;
using DigitalEducationServicec.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.MvcWebUI.Controllers.SystemSetup.GeneralPreparation
{
    public class StageController : Controller
    {
        private IMediator _mediatorInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();

        public StageController()
        {
        }

        public async Task<IActionResult> Index()
        {
            var query = new GetStageListQuery();
            var stageOptions = await _mediator.Send(query);
            return View("~/Views/Pages/SystemSetup/GeneralPreparations/Stages.cshtml", stageOptions.Data);

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Create(AddStageCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["message"] = "تم حفظ  بيانات المرحلة بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetStageListQuery();
            var stageOptions = await _mediator.Send(query);
            return View(command);
        }



        public async Task<IActionResult> Delete(DeleteStageCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["error"] = "تم   حذف المرحلة بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetStageListQuery();
            var stageOptions = await _mediator.Send(query);
            return View(command);
        }
        public async Task<IActionResult> Edit(EditStageCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["message"] = "تم تعديل  بيانات المرحلة بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetStageListQuery();
            var stageOptions = await _mediator.Send(query);
            return View(command);
        }


    }
}
