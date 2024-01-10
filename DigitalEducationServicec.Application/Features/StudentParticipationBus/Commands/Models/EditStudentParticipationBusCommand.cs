using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.StudentParticipationBus.Commands.Models
{
    public class EditStudentParticipationBusCommand : IRequest<Response<string>>
    {
        public long StudentParticipationBusId { get; set; }

        public long? FileStudentId { get; set; }

        public long? DistributionOfBuseStreetId { get; set; }

        public string? ParticipationType { get; set; }

        public DateTime? TimeAttendance { get; set; }

        public DateTime? TimeLeave { get; set; }

        public int? Status { get; set; }

        public string? Note { get; set; }

    }
}
