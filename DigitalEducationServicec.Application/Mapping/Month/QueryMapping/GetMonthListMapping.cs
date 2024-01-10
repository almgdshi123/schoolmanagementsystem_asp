using DigitalEducationServicec.Application.Features.Month.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Month
{
    public partial class MonthProfile

    {
        public void GetMonthListMapping()
        {
            CreateMap<MonthTb, GetMonthListResponse>();

        }


    }
}
