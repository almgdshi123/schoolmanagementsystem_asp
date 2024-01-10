using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Vacations
{
    public partial class VacationsProfile : Profile
    {
        public VacationsProfile()
        {
            GetVacationsListMapping();
            GetVacationByIDMapping();
            AddVacationCommandMapping();
            EditVacationCommandMapping();
        }
    }






}