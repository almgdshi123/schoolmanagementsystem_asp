using DigitalEducationServicec.Application.Features.Month.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Month
{
    public partial class MonthProfile

    {
        public void EditMonthCommandMapping()
        {
            CreateMap<EditMonthCommand, MonthTb>();

        }


    }
}
