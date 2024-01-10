using DigitalEducationServicec.Application.Features.ClassData.Commands.Models;
using DigitalEducationServicec.Application.Features.ClassData.Queries.Models;
using DigitalEducationServicec.Application.Features.Stage.Queries.Models;
using DigitalEducationServicec.MvcWebUI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DigitalEducationServicec.MvcWebUI.Controllers.SystemSetup.InitializeClass
{
    public class ClassDataController : Controller
    {
        private IMediator _mediatorInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();

     


        public async Task<IActionResult> Index()
        {
            var query = new GetClassDataListQuery();
            var ClassDataOptions = await _mediator.Send(query);
            var stageOptions = await _mediator.Send(new GetStageListQuery());
            ViewBag.stage = stageOptions.Data;
            return View("~/Views/pages/SystemSetup/InitializeClass/ClassData.cshtml", ClassDataOptions.Data);

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
                TempData["message"] = "تم حفظ  بيانات الصفوف بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetClassDataListQuery();
            var ClassDataOptions = await _mediator.Send(query);
            return View(command);
        }



        public async Task<IActionResult> Delete(DeleteClassDataCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["error"] = "تم   حذف الصفوف بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetClassDataListQuery();
            var ClassDataOptions = await _mediator.Send(query);
            return View(command);
        }
        public async Task<IActionResult> Edit(EditClassDataCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["message"] = "تم تعديل  بيانات الصفوف بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetClassDataListQuery();
            var ClassDataOptions = await _mediator.Send(query);
            return View(command);
        }
    }

}
