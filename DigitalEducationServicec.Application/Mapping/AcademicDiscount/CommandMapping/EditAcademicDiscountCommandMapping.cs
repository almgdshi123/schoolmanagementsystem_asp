using DigitalEducationServicec.Application.Features.AcademicDiscount.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.AcademicDiscount
{
    public partial class AcademicDiscountProfile
    {



        public void EditAcademicDiscountCommandMapping()
        {
            CreateMap<EditAcademicDiscountCommand, AcademicDiscountTb>();
        }
    }
}