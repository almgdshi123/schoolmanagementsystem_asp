using DigitalEducationServicec.Application.Features.Subject.Commands.Models;
using DigitalEducationServicec.Application.Features.Subject.Queries.Models;
using DigitalEducationServicec.MvcWebUI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DigitalEducationServicec.MvcWebUI.Controllers.SystemSetup.MaterialCreation
{
    public class SubjectController : Controller
    {
        private IMediator _mediatorInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();

        public SubjectController()
        {

        }


        public async Task<IActionResult> Index()
        {
            var query = new GetSubjectListQuery();
            var SubjectOptions = await _mediator.Send(query);
            return View("~/Views/pages/SystemSetup/MaterialCreation/Subject.cshtml", SubjectOptions.Data);

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Create(bool check, AddSubjectCommand command)
        {

            if (ModelState.IsValid)
            {
                command.SubjectIncludedInRate  = check;

                var classId = await _mediator.Send(command);
                TempData["message"] = "تم حفظ  بيانات الرسوم بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetSubjectListQuery();
            var SubjectOptions = await _mediator.Send(query);
            return View(command);
        }



        public async Task<IActionResult> Delete(DeleteSubjectCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["error"] = "تم   حذف الرسوم بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetSubjectListQuery();
            var SubjectOptions = await _mediator.Send(query);
            return View(command);
        }
        public async Task<IActionResult> Edit(bool check, EditSubjectCommand command)
        {

            if (ModelState.IsValid)
            {
                command.SubjectIncludedInRate = check;
                var classId = await _mediator.Send(command);
                TempData["message"] = "تم تعديل  بيانات الرسوم بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetSubjectListQuery();
            var SubjectOptions = await _mediator.Send(query);
            return View(command);
        }
    }
}
