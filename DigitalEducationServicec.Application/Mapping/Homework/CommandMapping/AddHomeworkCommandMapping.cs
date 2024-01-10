using DigitalEducationServicec.Application.Features.Homework.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Homework
{
    public partial class HomeworkProfile
    {
        public void AddHomeworkCommandMapping()
        {
            CreateMap<AddHomeworkCommand, HomeworkTb>();

        }
    }
}
