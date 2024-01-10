using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.AcademicDiscount.Commands.Models
{
    public class EditAcademicDiscountCommand : IRequest<Response<string>>
    {
        public long AcademicDiscountId { get; set; }

        public string? AcademicDiscountName { get; set; }

        public string? AcademicDiscountType { get; set; }

        public decimal? AmountDiscount { get; set; }

        public long? TypesDiscountId { get; set; }

        public string? YearId { get; set; }


    }
}
