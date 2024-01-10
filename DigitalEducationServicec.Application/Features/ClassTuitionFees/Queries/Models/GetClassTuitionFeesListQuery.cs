using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.ClassTuitionFees.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.ClassTuitionFees.Queries.Models
{
    public class GetClassTuitionFeesListQuery : IRequest<Response<List<GetClassTuitionFeesListResponse>>>
    {
    }
}
