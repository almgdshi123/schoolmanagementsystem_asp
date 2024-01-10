using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.ClassTuitionFees.Commands.Models
{
    public class DeleteClassTuitionFeesCommand : IRequest<Response<string>>
    {
        public long ClassTuitionFeesId { get; set; }


    }
}
