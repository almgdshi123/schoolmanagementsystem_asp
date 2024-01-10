using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Preparation.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Preparation.Queries.Models
{
    public class GetPreparationListQuery : IRequest<Response<List<GetPreparationListResponse>>>
    {
    }
}
