using DigitalEducationServicec.Application.Features.AcademicDiscount.Queries.Models;
using DigitalEducationServicec.Application.Features.AcademicDiscount.Commands.Models;
using DigitalEducationServicec.MvcWebUI.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.MvcWebUI.Controllers.SystemSetup.SetTuitionFees
{
    public class AcademicDiscountController : Controller
    {
        private IMediator _mediatorInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();

        public AcademicDiscountController()
        {
                
        }
 

        public async Task<IActionResult> Index()
        {
            var query = new GetAcademicDiscountListQuery();
            var academicDiscountOptions = await _mediator.Send(query);
            return View("~/Views/pages/SystemSetup/SetTuitionFees/AcademicDiscount.cshtml",academicDiscountOptions.Data) ;

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Create(AddAcademicDiscountCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["message"] = "تم حفظ  بيانات الخصم بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetAcademicDiscountListQuery();
            var AcademicDiscountOptions = await _mediator.Send(query);
            return View(command);
        }



        public async Task<IActionResult> Delete(DeleteAcademicDiscountCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["error"] = "تم   حذف الخصم بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetAcademicDiscountListQuery();
            var AcademicDiscountOptions = await _mediator.Send(query);
            return View(command);
        }
        public async Task<IActionResult> Edit(EditAcademicDiscountCommand command)
        {

            if (ModelState.IsValid)
            {

                var classId = await _mediator.Send(command);
                TempData["message"] = "تم تعديل  بيانات الخصم بنجاح";
                return RedirectToAction(nameof(Index));

            }
            var query = new GetAcademicDiscountListQuery();
            var AcademicDiscountOptions = await _mediator.Send(query);
            return View(command);
        }
    }
}
