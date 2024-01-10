using DigitalEducationServicec.Application.Features.MonthAcademic.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.MonthAcademic
{
    public partial class MonthAcademicProfile

    {
        public void GetMonthAcademicByIDMapping()
        {
            CreateMap<MonthAcademicTb, GetMonthAcademicListResponse>();

        }

    }
}
