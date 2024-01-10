using DigitalEducationServicec.Application.Features.SectionCode.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.SectionCode
{
    public partial class SectionCodeProfile
    {
        public void GetSectionCodeByIDMapping()
        {
            CreateMap<SectionCodeTb, GetSectionCodeListResponse>();
        }
    }

}
