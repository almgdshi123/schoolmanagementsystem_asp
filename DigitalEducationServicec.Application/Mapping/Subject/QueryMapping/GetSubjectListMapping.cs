using DigitalEducationServicec.Application.Features.Subject.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Subject
{
    public partial class SubjectProfile

    {
        public void GetSubjectListMapping()
        {
            CreateMap<SubjectTb, GetSubjectListResponse>();

        }
    }
}
