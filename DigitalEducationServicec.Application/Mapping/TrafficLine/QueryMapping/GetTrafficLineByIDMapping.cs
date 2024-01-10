using DigitalEducationServicec.Application.Features.TrafficLine.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.TrafficLine
{
    public partial class TrafficLineProfile
    {

        public void GetTrafficLineByIDMapping()
        {
            CreateMap<TrafficLineTb, GetTrafficLineListResponse>();
        }
    }
}
