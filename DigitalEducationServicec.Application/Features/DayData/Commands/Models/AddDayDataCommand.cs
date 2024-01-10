using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DayData.Commands.Models
{
    public class AddDayDataCommand : IRequest<Response<string>>
    {

        public string? DayName { get; set; }

        public string? Notes { get; set; }
    }
}
