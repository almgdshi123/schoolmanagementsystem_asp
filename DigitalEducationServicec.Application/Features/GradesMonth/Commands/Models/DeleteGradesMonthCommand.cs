using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.GradesMonth.Commands.Models
{
    public class DeleteGradesMonthCommand : IRequest<Response<string>>
    {
        public long GradesMonthId { get; set; }




    }
}
