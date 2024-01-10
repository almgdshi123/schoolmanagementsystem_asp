using DigitalEducationServicec.Application.Features.SchoolGroup.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.SchoolGroup
{
    public partial class SchoolGroupProfile
    {
        public void GetSchoolGroupByIDMapping()
        {
            CreateMap<SchoolGroupTb, GetSchoolGroupListResponse>();

        }


    }
}
