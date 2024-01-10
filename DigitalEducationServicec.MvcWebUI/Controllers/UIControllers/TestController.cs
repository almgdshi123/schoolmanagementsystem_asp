using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.MvcWebUI.Controllers.UIControllers
{
    [Route("test/{action}")]
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //معلومات المدرسة
        public IActionResult InformationSchool()
        {
            return View("~/Views/pages/UIPages/InformationSchool.cshtml");
        }
        //دليل  السنوات الدراسية
        public IActionResult SchoolYear()
        {
            return View("~/Views/pages/UIPages/Schoolyear.cshtml");
        }
        //دليل  الاقسام الدراسية
        public IActionResult GuideSections()
        {
            return View("~/Views/pages/UIPages/GuideSections.cshtml");
        }
        //دليل  رموز الشعب
        public IActionResult GuideCodeDivision()
        {
            return View("~/Views/pages/UIPages/GuideCodeDivision.cshtml");
        }        //دليل   الشعب
        public IActionResult GuideDivision()
        {
            return View("~/Views/pages/UIPages/GuideDivision.cshtml");
        }

        //دليل  المراحل الدراسية
        public IActionResult GuideStages()
        {
            return View("~/Views/pages/UIPages/GuideStages.cshtml");
        }
        //دليل  الحصص الدراسية
        public IActionResult GuideClasses()
        {
            return View("~/Views/pages/UIPages/GuideClasses.cshtml");
        }
        //دليل  الوثاق الدراسية
        public IActionResult GuideDocuments()
        {
            return View("~/Views/pages/UIPages/GuideDocuments.cshtml");
        }
        //دليل  الجنسيات 
        public IActionResult GuideNationality()
        {
            return View("~/Views/pages/UIPages/GuideNationality.cshtml");
        }
        //دليل الاشعارت الطلابي
        public IActionResult GuideNotifications()
        {
            return View("~/Views/pages/UIPages/GuideNotifications.cshtml");
        }
        //دليل المخلفات الطلابي
        public IActionResult GuideResidue()
        {
            return View("~/Views/pages/UIPages/GuideResidue.cshtml");
        }
        //التقويم الدراسي
        public IActionResult AcademicCalendar()
        {
            return View("~/Views/pages/UIPages/AcademicCalendar.cshtml");
        }
        // الخطة الدرسية
        public IActionResult AcademicPlan()
        {
            return View("~/Views/pages/UIPages/AcademicPlan.cshtml");
        }
        //دليل الايام
        public IActionResult AcademicDay()
        {
            return View("~/Views/pages/UIPages/AcademicDay.cshtml");
        }

        //دليل الاشهر الدراسية
        public IActionResult AcademicMonth()
        {
            return View("~/Views/pages/UIPages/AcademicMonth.cshtml");
        }
        //دليل الجازات الدراسية
        public IActionResult AcademicHoliday()
        {
            return View("~/Views/pages/UIPages/AcademicHoliday.cshtml");
        }
        //دليل الصفوف الدراسية
        public IActionResult InformationClasss()
        {
            return View("~/Views/pages/UIPages/InformationClasss.cshtml");
        }
        //دليل التدرج 
        public IActionResult GuideGradient()
        {
            return View("~/Views/pages/UIPages/GuideGradient.cshtml");
        }
        //دليل المواد الدرسية GuideMaterials
        public IActionResult GuideMaterials()
        {
            return View("~/Views/pages/UIPages/GuideMaterials.cshtml");
        }

        // دليل المواد التقديرية GuideMaterialsNotRequired
        public IActionResult GuideMaterialsNotRequired()
        {
            return View("~/Views/pages/UIPages/GuideMaterialsNotRequired.cshtml");
        }

        // توزيع المواد على الصفوف Materialst_Classes

        public IActionResult Materialst_Classes()
        {
            return View("~/Views/pages/UIPages/Materialst_Classes.cshtml");
        }
        //دليل نواع الدرجات الدرسية GuideTypesGrade
        public IActionResult GuideTypesGrade()
        {
            return View("~/Views/pages/UIPages/GuideTypesGrade.cshtml");
        }
        //الاعدادت  PageSettings
        public IActionResult PageSettings()
        {
            return View("~/Views/pages/UIPages/PageSettings.cshtml");
        }

   
        //GuideFeeCategory دليل فئاة الرسوم

        public IActionResult GuideFeeCategory()
        {
            return View("~/Views/pages/UIPages/GuideFeeCategory.cshtml");
        }
        //GuideDiscountCategory دليل فئاة الخصم


        public IActionResult GuideDiscountCategory()
        {
            return View("~/Views/pages/UIPages/GuideDiscountCategory.cshtml");
        }
        //GuideInstallmentCategory دليل فئاة الاقساط

        public IActionResult GuideInstallmentCategory()
        {
            return View("~/Views/pages/UIPages/GuideInstallmentCategory.cshtml");
        }

        //DetailsFeesInstalments تفاصيل اقساط الرسوم الداسية 
        public IActionResult DetailsFeesInstalments()
        {
            return View("~/Views/pages/UIPages/DetailsFeesInstalments.cshtml");
        }

        //DetailsFeesInstalments تفاصيل اقساط الرسوم الداسية 
        public IActionResult Add_bus()
        {
            return View("~/Views/pages/UIPages/Add_bus.cshtml");
        }

    }
}
