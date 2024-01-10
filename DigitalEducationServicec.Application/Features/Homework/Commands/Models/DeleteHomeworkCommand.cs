using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Homework.Commands.Models
{
    public class DeleteHomeworkCommand : IRequest<Response<string>>
    {
        public long HomeworkId { get; set; }



    }
}
