using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.TypeOfActivities.Commands.Models
{
    public class EditTypeOfActivitiesCommand : IRequest<Response<string>>
    {
        public long TypeOfActivitieId { get; set; }

        public string? TypeOfActivitieName { get; set; }

        public string? Note { get; set; }

    }
}
