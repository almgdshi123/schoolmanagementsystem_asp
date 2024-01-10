using DigitalEducationServicec.Application.Features.GradesMonth.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.GradesMonth
{
    public partial class GradesMonthProfile
    {
        public void GetGradesMonthByIDMapping()
        {
            CreateMap<GradesMonthTb, GetGradesMonthListResponse>();

        }


    }
}
