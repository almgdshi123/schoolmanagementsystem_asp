using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.DocmunetStudent
{
    public partial class DocmunetStudentProfile : Profile
    {
        public DocmunetStudentProfile()
        {
            GetDocmunetStudentListMapping();
            GetDocmunetStudentByIDMapping();
            AddDocmunetStudentCommandMapping();
            EditDocmunetStudentCommandMapping();
        }
    }





}
