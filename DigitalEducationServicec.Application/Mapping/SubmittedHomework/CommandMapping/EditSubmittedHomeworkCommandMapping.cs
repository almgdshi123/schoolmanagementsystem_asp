using DigitalEducationServicec.Application.Features.SubmittedHomework.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.SubmittedHomework
{
    public partial class SubmittedHomeworkProfile
    {
        public void EditSubmittedHomeworkCommandMapping()
        {
            CreateMap<EditSubmittedHomeworkCommand, SubmittedHomeworkTb>();

        }

    }
}
