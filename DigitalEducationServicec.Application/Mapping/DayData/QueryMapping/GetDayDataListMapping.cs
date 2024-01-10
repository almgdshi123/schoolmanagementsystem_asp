using DigitalEducationServicec.Application.Features.DayData.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.DayData
{
    public partial class DayDataProfile
    {
        public void GetDayDataListMapping()
        {
            CreateMap<DayDataTb, GetDayDataListResponse>();
        }

    }
}
