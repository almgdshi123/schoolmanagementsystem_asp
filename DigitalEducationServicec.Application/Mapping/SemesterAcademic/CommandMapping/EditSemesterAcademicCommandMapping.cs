using DigitalEducationServicec.Application.Features.SemesterAcademic.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.SemesterAcademic
{
    public partial class SemesterAcademicProfile

    {
        public void EditSemesterAcademicCommandMapping()
        {
            CreateMap<EditSemesterAcademicCommand, SemesterAcademicTb>();

        }


    }
}
