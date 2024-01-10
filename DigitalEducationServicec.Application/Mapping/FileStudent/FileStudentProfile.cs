using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.FileStudent
{
    public partial class FileStudentProfile : Profile
    {
        public FileStudentProfile()
        {
            GetFileStudentListMapping();
            GetFileStudentByIDMapping();
            AddFileStudentCommandMapping();
            EditFileStudentCommandMapping();
            //    GetStudentPaginationMapping();
        }
    }
}
