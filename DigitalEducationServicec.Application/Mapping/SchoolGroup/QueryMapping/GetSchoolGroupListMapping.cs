using DigitalEducationServicec.Application.Features.SchoolGroup.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.SchoolGroup
{
    public partial class SchoolGroupProfile
    {
        public void GetSchoolGroupListMapping()
        {
            CreateMap<SchoolGroupTb, GetSchoolGroupListResponse>();

        }


    }
}
