using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DistributionSubTeacher.Commands.Models
{
    public class DeleteDistributionSubTeacherCommand : IRequest<Response<string>>
    {
        public long DistrSubTeacherId { get; set; }



    }
}
