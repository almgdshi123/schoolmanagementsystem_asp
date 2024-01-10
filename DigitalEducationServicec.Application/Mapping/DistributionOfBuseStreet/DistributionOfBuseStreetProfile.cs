using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.DistributionOfBuseStreet
{
    public partial class DistributionOfBuseStreetProfile : Profile
    {
        public DistributionOfBuseStreetProfile()
        {
            GetDistributionOfBuseStreetListMapping();
            GetDistributionOfBuseStreetByIDMapping();
            AddDistributionOfBuseStreetCommandMapping();
            EditDistributionOfBuseStreetCommandMapping();
        }
    }


}