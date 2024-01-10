using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Subject.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Subject.Queries.Models
{
    public class GetSubjectByIDQuery : IRequest<Response<GetSingleSubjectResponse>>
    {
        public long Id { get; set; }
        public GetSubjectByIDQuery(long id)
        {
            Id = id;
        }
    }
}
