using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.AcademicDiscount.Commands.Models
{
    public class DeleteAcademicDiscountCommand : IRequest<Response<string>>
    {
        public long AcademicDiscountId { get; set; }
    }
}
