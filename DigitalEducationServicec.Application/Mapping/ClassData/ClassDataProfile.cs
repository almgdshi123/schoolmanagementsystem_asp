using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.ClassData
{
    public partial class ClassDataProfile : Profile
    {
        public ClassDataProfile()
        {
            GetClassDataListMapping();
            //GetStudentByIDMapping();
            AddClassDataCommandMapping();
            EditClassDataCommandMapping();
            //GetStudentPaginationMapping();
        }
        //}
    }
}
