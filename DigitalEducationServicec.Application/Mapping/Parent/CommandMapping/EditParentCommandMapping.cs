using DigitalEducationServicec.Application.Features.Parent.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Parent
{
    public partial class ParentProfile
    {
        public void EditParentCommandMapping()
        {
            CreateMap<EditParentCommand, ParentTb>();

        }
    }
}
