using DigitalEducationServicec.Application.Features.School.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.School
{
    public partial class SchoolProfile

    {
        public void GetSchoolByIDMapping()
        {
            CreateMap<SchoolTb, GetSchoolListResponse>();

        }


    }
}
