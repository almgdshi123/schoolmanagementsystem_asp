using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.TypeOfActivities.Commands.Models
{
    public class AddTypeOfActivitiesCommand : IRequest<Response<string>>
    {

        public string? TypeOfActivitieName { get; set; }

        public string? Note { get; set; }

    }
}
