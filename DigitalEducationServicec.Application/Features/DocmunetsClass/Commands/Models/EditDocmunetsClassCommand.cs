using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DocmunetsClass.Commands.Models
{
    public class EditDocmunetsClassCommand : IRequest<Response<string>>
    {
        public long DocmunetsClassId { get; set; }

        public long DocmunetId { get; set; }

        public long ClassId { get; set; }

        public string DocmunetName { get; set; } = null!;

        public string? Notes { get; set; }
    }
}
