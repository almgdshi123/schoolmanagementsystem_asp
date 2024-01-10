using DigitalEducationServicec.Application.Features.ParticiStudentActiv.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.ParticiStudentActiv
{
    public partial class PartiStudentActivProfile
    {
        public void GetPartiStudentActivListMapping()
        {
            CreateMap<ParticiStudentActivTb, GetParticiStudentActivListResponse>();
        }
    }
}
