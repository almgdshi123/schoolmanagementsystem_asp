using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.SubmittedHomework.Commands.Models
{
    public class DeleteSubmittedHomeworkCommand : IRequest<Response<string>>
    {
        public long SubmittedHomeworkId { get; set; }


    }
}
