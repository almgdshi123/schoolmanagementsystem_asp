using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.TypeOfActivities.Commands.Models
{
    public class DeleteTypeOfActivitiesCommand : IRequest<Response<string>>
    {
        public long TypeOfActivitieId { get; set; }



    }
}
