using DigitalEducationServicec.Application.Features.AcademicStatuses.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.AcademicStatuses
{
    public partial class AcademicStatusesProfile
    {
        public void EditAcademicStatusesCommandMapping()
        {
            CreateMap<EditAcademicStatusCommand, AcademicStatusesTb>();

        }
    }
}
