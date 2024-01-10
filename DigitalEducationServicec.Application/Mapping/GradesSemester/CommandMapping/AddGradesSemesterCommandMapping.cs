using DigitalEducationServicec.Application.Features.GradesSemester.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.GradesSemester
{
    public partial class GradesSemesterProfile
    {
        public void AddGradesSemesterCommandMapping()
        {
            CreateMap<AddGradesSemesterCommand, GradesSemesterTb>();

        }
    }
}
