using DigitalEducationServicec.Application.Features.GradesMonth.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.GradesMonth
{
    public partial class GradesMonthProfile
    {
        public void EditGradesMonthCommandMapping()
        {
            CreateMap<EditGradesMonthCommand, GradesMonthTb>();

        }
    }
}
