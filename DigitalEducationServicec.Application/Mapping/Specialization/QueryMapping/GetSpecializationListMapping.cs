using DigitalEducationServicec.Application.Features.Specialization.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Specialization
{
    public partial class SpecializationProfile

    {
        public void GetSpecializationListMapping()
        {
            CreateMap<SpecializationTb, GetSpecializationListResponse>();

        }


    }
}
