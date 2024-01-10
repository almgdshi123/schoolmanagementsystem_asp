using DigitalEducationServicec.Application.Features.DistributionClassSub.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.DistributionClassSub
{
    public partial class DistributionClassSubProfile
    {
        public void GetDistributionClassSubByIDMapping()
        {
            CreateMap<DistributionClassSubTb, GetDistributionClassSubListResponse>();

        }


    }
}
