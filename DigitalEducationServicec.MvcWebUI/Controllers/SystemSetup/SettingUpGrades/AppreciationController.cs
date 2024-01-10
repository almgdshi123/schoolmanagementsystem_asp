using DigitalEducationServicec.Application.Features.Appreciation.Commands.Models;
using DigitalEducationServicec.Application.Features.Appreciation.Queries.Models;
using DigitalEducationServicec.MvcWebUI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DigitalEducationServicec.MvcWebUI.Controllers.SystemSetup.SettingUpGrades
{
    public class AppreciationController : Controller
    {
     
            private IMediator _mediatorInstance;
            protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();

            public AppreciationController()
            {

            }


            public async Task<IActionResult> Index()
            {
                var query = new GetAppreciationListQuery();
                var AppreciationOptions = await _mediator.Send(query);
                return View("~/Views/pages/SystemSetup/SettingUpGrades/Appreciation.cshtml", AppreciationOptions.Data);

            }
            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
            public async Task<IActionResult> Create(AddAppreciationCommand command)
            {

                if (ModelState.IsValid)
                {

                    var classId = await _mediator.Send(command);
                    TempData["message"] = "تم حفظ  بيانات التقدير بنجاح";
                    return RedirectToAction(nameof(Index));

                }
                var query = new GetAppreciationListQuery();
                var AppreciationOptions = await _mediator.Send(query);
                return View(command);
            }



            public async Task<IActionResult> Delete(DeleteAppreciationCommand command)
            {

                if (ModelState.IsValid)
                {

                    var classId = await _mediator.Send(command);
                    TempData["error"] = "تم   حذف التقدير بنجاح";
                    return RedirectToAction(nameof(Index));

                }
                var query = new GetAppreciationListQuery();
                var AppreciationOptions = await _mediator.Send(query);
                return View(command);
            }
            public async Task<IActionResult> Edit(EditAppreciationCommand command)
            {

                if (ModelState.IsValid)
                {

                    var classId = await _mediator.Send(command);
                    TempData["message"] = "تم تعديل  بيانات التقدير بنجاح";
                    return RedirectToAction(nameof(Index));

                }
                var query = new GetAppreciationListQuery();
                var AppreciationOptions = await _mediator.Send(query);
                return View(command);
            }
        }
    }

