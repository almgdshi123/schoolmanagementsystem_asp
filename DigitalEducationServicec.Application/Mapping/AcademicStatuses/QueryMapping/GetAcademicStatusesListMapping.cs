using DigitalEducationServicec.Application.Features.AcademicStatuses.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.AcademicStatuses
{
    public partial class AcademicStatusesProfile
    {
        public void GetAcademicStatusesListMapping()
        {
            CreateMap<AcademicStatusesTb, GetAcademicStatusesListResponse>();

        }
    }
}
