using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Subject.Commands.Models
{
    public class DeleteSubjectCommand : IRequest<Response<string>>
    {
        public long SubjectId { get; set; }


    }
}
