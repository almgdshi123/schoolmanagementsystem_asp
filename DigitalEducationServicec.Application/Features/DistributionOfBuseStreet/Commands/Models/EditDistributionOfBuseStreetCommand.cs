using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DistributionOfBuseStreet.Commands.Models
{
    public class EditDistributionOfBuseStreetCommand : IRequest<Response<string>>
    {
        public long DistributionOfBuseStreetId { get; set; }

        public long? StreetId { get; set; }

        public long? BusId { get; set; }

        public DateTime? DistributionDate { get; set; }

        public string? YearId { get; set; }


    }
}
