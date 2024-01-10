using DigitalEducationServicec.Application.Features.SectionData.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.SectionData
{
    public partial class SectionDataProfile

    {
        public void GetSectionDataByIDMapping()
        {
            CreateMap<SectionDataTb, GetSectionDataListResponse>();

        }


    }
}
