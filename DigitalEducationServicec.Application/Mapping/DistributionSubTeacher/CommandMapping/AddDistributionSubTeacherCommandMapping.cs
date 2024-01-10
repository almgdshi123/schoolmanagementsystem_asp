using DigitalEducationServicec.Application.Features.DistributionSubTeacher.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.DistributionSubTeacher
{
    public partial class DistributionSubTeacherProfile
    {
        public void AddDistributionSubTeacherCommandMapping()
        {
            CreateMap<AddDistributionSubTeacherCommand, DistributionSubTeacherTb>();

        }
    }
}
