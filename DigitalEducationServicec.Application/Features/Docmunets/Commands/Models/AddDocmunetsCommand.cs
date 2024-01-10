using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Docmunets.Commands.Models
{
    public class AddDocmunetsCommand : IRequest<Response<string>>
    {

        public string DocmunetName { get; set; } = null!;

        public string? Notes { get; set; }

    }
}
