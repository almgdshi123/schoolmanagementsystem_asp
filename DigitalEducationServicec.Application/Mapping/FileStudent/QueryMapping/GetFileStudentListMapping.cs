using DigitalEducationServicec.Application.Features.FileStudent.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.FileStudent
{
    public partial class FileStudentProfile
    {
        public void GetFileStudentListMapping()
        {
            CreateMap<FileStudentTb, GetFileStudentListResponse>();

        }


    }
}
