using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.TypesDiscounts.Queries.Results;
using MediatR;


namespace DigitalEducationServicec.Application.Features.TypesDiscounts.Queries.Models
{
    public class GetTypesDiscountsListQuery : IRequest<Response<List<GetTypesDiscountsListResponse>>>
    {
    }
}
