using DigitalEducationServicec.Application.Features.Streets.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Streets
{
    public partial class StreetsProfile
    {
        public void GetStreetByIDMapping()
        {
            CreateMap<StreetsTb, GetStreetsListResponse>();
        }
    }
}
