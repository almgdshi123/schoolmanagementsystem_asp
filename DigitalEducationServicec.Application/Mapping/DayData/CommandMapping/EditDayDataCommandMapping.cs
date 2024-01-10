using DigitalEducationServicec.Application.Features.DayData.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.DayData
{
    public partial class DayDataProfile
    {



        public void EditDayDataCommandMapping()
        {
            CreateMap<EditDayDataCommand, DayDataTb>();
        }
    }



}
