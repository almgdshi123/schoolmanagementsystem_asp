using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.DayData.Commands.Models
{
    public class DeleteDayDataCommand : IRequest<Response<string>>
    {
        public int DayId { get; set; }


    }
}
