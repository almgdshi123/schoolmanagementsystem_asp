using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.DistributionClassSub
{
    public partial class DistributionClassSubProfile : Profile
    {
        public DistributionClassSubProfile()
        {
            GetDistributionClassSubListMapping();
            GetDistributionClassSubByIDMapping();
            AddDistributionClassSubCommandMapping();
            EditDistributionClassSubCommandMapping();
            //    GetStudentPaginationMapping();
        }
    }
}
