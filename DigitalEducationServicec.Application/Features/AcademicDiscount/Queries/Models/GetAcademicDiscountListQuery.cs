using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.AcademicDiscount.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.AcademicDiscount.Queries.Models
{
    public class GetAcademicDiscountListQuery : IRequest<Response<List<GetAcademicDiscountListResponse>>>
    {
    }
}
