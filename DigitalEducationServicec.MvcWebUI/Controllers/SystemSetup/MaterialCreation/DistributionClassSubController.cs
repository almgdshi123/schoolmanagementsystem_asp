using DigitalEducationServicec.Application.Features.ClassData.Queries.Models;
using DigitalEducationServicec.Application.Features.DistributionClassSub.Commands.Models;
using DigitalEducationServicec.Application.Features.DistributionClassSub.Queries.Models;
using DigitalEducationServicec.Application.Features.DistributionClassSub.Queries.Results;
using DigitalEducationServicec.Application.Features.Subject.Queries.Models;
using DigitalEducationServicec.MvcWebUI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Diagnostics;

namespace DigitalEducationServicec.MvcWebUI.Controllers.SystemSetup.MaterialCreation
{
    public class DistributionClassSubController : Controller
    {
        private IMediator _mediatorInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();

        public DistributionClassSubController()
        {

        }
        public async Task<List<GetDistributionClassSubListResponse>> GetSubject()
        {

            var query = new GetDistributionClassSubListQuery();
            var DistributionClassSubOptions = await _mediator.Send(query);
            return DistributionClassSubOptions.Data;


        }
        public async Task<int> FindSubject(long ClassId, long? SubjectId)
        {

            var query = new GetDistributionClassSubListQuery();
            var DistributionClassSubOptions = await _mediator.Send(query);
            var find = DistributionClassSubOptions.Data.Where(x => x.ClassId == ClassId && x.SubjectId == SubjectId);
            return find.Count();

        }

        public async Task<IActionResult> Index()
        {
            var query = new GetDistributionClassSubListQuery();
            var DistributionClassSubOptions = await _mediator.Send(query);
            var SubjectOptions = await _mediator.Send(new GetSubjectListQuery());
            var ClassDataOptions = await _mediator.Send(new GetClassDataListQuery());


            ViewBag.Class = ClassDataOptions.Data;
            ViewBag.Subject = SubjectOptions.Data;
            return View("~/Views/pages/SystemSetup/MaterialCreation/DistributionClassSub.cshtml", DistributionClassSubOptions.Data);

        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Create(AddDistributionClassSubCommand command, int[] SubjectId)
        {

            if (ModelState.IsValid)
            {

                foreach (var item in SubjectId)
                {
                    command.SubjectId = item;

                    var classId = await _mediator.Send(command);
                }
                TempData["message"] = "تم حفظ  البيانات  بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetDistributionClassSubListQuery();
            var DistributionClassSubOptions = await _mediator.Send(query);
            return View(command);
        }
        public async Task<IActionResult> AddSubject(AddDistributionClassSubCommand command)
        {

            if (ModelState.IsValid)
            {

                if (FindSubject(command.ClassId, command.SubjectId).Result != 0)
                {
                    TempData["warning"] = "  المادة موجودة بالفغل";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    var classId = await _mediator.Send(command);

                    TempData["message"] = "تم اظافة المادة بنجاح";
                    return RedirectToAction(nameof(Index));


                }

            }
            var query = new GetDistributionClassSubListQuery();
            var DistributionClassSubOptions = await _mediator.Send(query);
            return View(command);
        }

        public async Task<IActionResult> Delete(DeleteDistributionClassSubCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["error"] = "تم   حذف المادة بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetDistributionClassSubListQuery();
            var DistributionClassSubOptions = await _mediator.Send(query);
            return View(command);
        }
        public async Task<IActionResult> DeleteِAli(DeleteDistributionClassSubCommand command, long ClassId)
        {


            if (ModelState.IsValid)
            {
                var getSubject = GetSubject().Result.Where(x => x.ClassId == ClassId);
                if (getSubject.Count() != 0)
                {
                    foreach (var itme in getSubject)
                    {
                        command.DistrClassSubId = itme.DistrClassSubId;
                        var classId = await _mediator.Send(command);

                    }
                    TempData["error"] = "تم حذف كل المواد بنجاح";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["warning"] = "لايوجد مواد لحذفها";
                    return RedirectToAction(nameof(Index));
                }
            }
            var query = new GetDistributionClassSubListQuery();
            var DistributionClassSubOptions = await _mediator.Send(query);
            return View(command);
        }

    }
}
