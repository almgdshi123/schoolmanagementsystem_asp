using DigitalEducationServicec.Application.Features.DistributionSubTeacher.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.DistributionSubTeacher
{
    public partial class DistributionSubTeacherProfile
    {
        public void GetDistributionSubTeacherListMapping()
        {
            CreateMap<DistributionSubTeacherTb, GetDistributionSubTeacherListResponse>();

        }

    }
}
