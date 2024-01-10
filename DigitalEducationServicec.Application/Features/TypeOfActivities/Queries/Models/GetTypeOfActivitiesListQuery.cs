using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.TypeOfActivities.Queries.Results;
using MediatR;


namespace DigitalEducationServicec.Application.Features.TypeOfActivities.Queries.Models
{
    public class GetTypeOfActivitiesListQuery : IRequest<Response<List<GetTypeOfActivitiesListResponse>>>
    {
    }
}
