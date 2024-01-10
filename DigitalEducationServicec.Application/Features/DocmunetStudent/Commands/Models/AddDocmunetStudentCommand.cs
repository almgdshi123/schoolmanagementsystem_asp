using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DocmunetStudent.Commands.Models
{
    public class AddDocmunetStudentCommand : IRequest<Response<string>>
    {

        public long DocmunetsClassId { get; set; }

        public long FileStudentId { get; set; }

        public string DocmunetType { get; set; } = null!;

        public string DocmunetStatus { get; set; } = null!;

        public string? Notes { get; set; }


    }
}
