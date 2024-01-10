using DigitalEducationServicec.Application.Features.DistributionOfBuseStreet.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.DistributionOfBuseStreet
{
    public partial class DistributionOfBuseStreetProfile
    {


        public void GetDistributionOfBuseStreetByIDMapping()
        {
            CreateMap<DistributionOfBuseStreetTb, GetDistributionOfBuseStreetByIDResponse>();
        }

    }
}
