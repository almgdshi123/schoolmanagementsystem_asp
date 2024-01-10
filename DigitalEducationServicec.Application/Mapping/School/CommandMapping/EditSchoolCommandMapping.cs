using DigitalEducationServicec.Application.Features.School.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.School
{
    public partial class SchoolProfile

    {
        public void EditSchoolCommandMapping()
        {
            CreateMap<EditSchoolCommand, SchoolTb>();

        }


    }
}
