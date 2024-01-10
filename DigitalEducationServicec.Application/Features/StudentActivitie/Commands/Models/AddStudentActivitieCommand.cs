using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.StudentActivitie.Commands.Models
{
    public class AddStudentActivitieCommand : IRequest<Response<string>>
    {

        public string StudentActivitieName { get; set; } = null!;

        public long? TypeOfActivitieId { get; set; }

        public long? TeacherId { get; set; }

        public DateTime? StudentActivitieDateSt { get; set; }

        public DateTime? StudentActivitieDateEnd { get; set; }

        public decimal? Amount { get; set; }

        public string? Location { get; set; }

        public string? Status { get; set; }

        public string? Notes { get; set; }

    }
}
