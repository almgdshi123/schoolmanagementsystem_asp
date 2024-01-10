using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Preparation
{
    public partial class PreparationProfile : Profile
    {
        public PreparationProfile()
        {
            GetPreparationListMapping();
            GetPreparationByIDMapping();
            AddPreparationCommandMapping();
            EditPreparationCommandMapping();
            //GetStudentPaginationMapping();
        }
    }
}
