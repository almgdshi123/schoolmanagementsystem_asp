using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Bus.Commands.Models
{
    public class EditBusCommand : IRequest<Response<string>>
    {
        public long BusId { get; set; }

        public string? BusDriverName { get; set; }

        public string? Phone { get; set; }

        public string? Address { get; set; }

        public string? PlateNumber { get; set; }

        public string? BusType { get; set; }

        public string? HelperName { get; set; }

        public string? SupervisorName { get; set; }

        public DateTime? TimeAttendance { get; set; }

        public DateTime? TimeLeave { get; set; }

        public string? Notes { get; set; }

    }
}
