using DigitalEducationServicec.Application.Features.Semesters.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Semester
{
    public partial class SemesterProfile
    {
        public void EditSemesterCommandMapping()
        {
            CreateMap<EditSemesterCommand, SemesterTb>();

        }
    }
}