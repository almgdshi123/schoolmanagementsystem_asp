using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Month.Commands.Models
{
    public class DeleteMonthCommand : IRequest<Response<string>>
    {
        public long MonthId { get; set; }



    }
}
