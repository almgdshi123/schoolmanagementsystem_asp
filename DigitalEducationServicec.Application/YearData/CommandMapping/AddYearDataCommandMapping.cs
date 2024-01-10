using DigitalEducationServicec.Application.Features.YearData.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.YearData
{
    public partial class YearDataProfile
    {


        public void AddYearDataCommandMapping()
        {
            CreateMap<AddYearDataCommand, YearDataTb>();

        }


    }
}
