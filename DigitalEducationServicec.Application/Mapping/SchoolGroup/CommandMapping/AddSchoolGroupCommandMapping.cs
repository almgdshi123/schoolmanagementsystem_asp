using DigitalEducationServicec.Application.Features.SchoolGroup.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.SchoolGroup
{
    public partial class SchoolGroupProfile
    {
        public void AddSchoolGroupCommandMapping()
        {
            CreateMap<AddSchoolGroupCommand, SchoolGroupTb>();

        }
    }
}
