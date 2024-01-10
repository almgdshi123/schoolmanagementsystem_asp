using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DayData.Commands.Models
{
    public class EditDayDataCommand : IRequest<Response<string>>
    {
        public int DayId { get; set; }

        public string? DayName { get; set; }

        public string? Notes { get; set; }
    }
}
