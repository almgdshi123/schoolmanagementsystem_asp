using DigitalEducationServicec.Application.Features.AcademicSystems.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.AcademicSystems
{
    public partial class AcademicSystemsProfile
    {
        public void GetAcademicSystemsByIDMapping()
        {
            CreateMap<AcademicSystemsTb, GetAcademicSystemsListResponse>();

        }


    }
}
