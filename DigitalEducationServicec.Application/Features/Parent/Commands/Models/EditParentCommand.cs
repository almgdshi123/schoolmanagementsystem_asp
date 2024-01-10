using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Parent.Commands.Models
{
    public class EditParentCommand : IRequest<Response<string>>
    {
        public long ParentId { get; set; }

        public string? ParentName { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }

        public string? Gender { get; set; }
    }
}
