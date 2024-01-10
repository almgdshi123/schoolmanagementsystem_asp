using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Docmunets.Commands.Models
{
    public class EditDocmunetsCommand : IRequest<Response<string>>
    {
        public long DocmunetId { get; set; }

        public string DocmunetName { get; set; } = null!;

        public string? Notes { get; set; }

    }
}
