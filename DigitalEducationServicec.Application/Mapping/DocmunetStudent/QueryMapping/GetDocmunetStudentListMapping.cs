using DigitalEducationServicec.Application.Features.DocmunetStudent.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.DocmunetStudent
{
    public partial class DocmunetStudentProfile
    {
        public void GetDocmunetStudentListMapping()
        {
            CreateMap<DocmunetStudentTb, GetDocmunetStudentListResponse>();
        }
    }
}
