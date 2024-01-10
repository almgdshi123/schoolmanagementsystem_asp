using DigitalEducationServicec.Application.Features.MonthAcademic.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.MonthAcademic
{
    public partial class MonthAcademicProfile

    {
        public void AddMonthAcademicCommandMapping()
        {
            CreateMap<AddMonthAcademicCommand, MonthAcademicTb>();

        }
    }
}
