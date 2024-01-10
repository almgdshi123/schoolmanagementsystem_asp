using DigitalEducationServicec.Application.Features.Appreciation.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Appreciation
{
    public partial class AppreciationProfile
    {

        public void GetAppreciationByIDMapping()
        {
            CreateMap<AppreciationTb, GetAppreciationListResponse>();
        }

    }
}
