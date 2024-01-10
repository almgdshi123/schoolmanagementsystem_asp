using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Specialization.Queries.Results;
using MediatR;


namespace DigitalEducationServicec.Application.Features.Specialization.Queries.Models
{
    public class GetSpecializationListQuery : IRequest<Response<List<GetSpecializationListResponse>>>
    {
    }
}
