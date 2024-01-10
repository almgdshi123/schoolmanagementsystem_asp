using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DocmunetsClass.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DocmunetsClass.Queries.Models
{
    public class GetDocmumentsClassListQuery : IRequest<Response<List<GetDocmunetsClassListResponse>>>
    {
    }
}
