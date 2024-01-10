using DigitalEducationServicec.Application.Features.JopType.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.JopType
{
    public partial class JopTypeProfile
    {
        public void GetJopTypeListMapping()
        {
            CreateMap<JopTypeTb, GetJopTypeListResponse>();
        }
    }
}
