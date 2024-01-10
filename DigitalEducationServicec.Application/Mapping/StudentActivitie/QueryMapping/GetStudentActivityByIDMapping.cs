using DigitalEducationServicec.Application.Features.StudentActivitie.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.StudentActivitie
{
    public partial class StudentActivityProfile
    {
        public void GetStudentActivityByIDMapping()
        {
            CreateMap<StudentActivitieTb, GetStudentActivitieByIDResponse>();
        }
    }

}
