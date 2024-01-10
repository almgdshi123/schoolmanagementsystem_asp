using DigitalEducationServicec.Application.Features.Vacations.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Vacations
{
    public partial class VacationsProfile
    {
        public void GetVacationByIDMapping()
        {
            CreateMap<VacationsTb, GetVacationsListResponse>();
        }
    }

}
