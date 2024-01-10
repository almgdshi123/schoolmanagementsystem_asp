using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DistributionOfBuseStreet.Commands.Models
{
    public class AddDistributionOfBuseStreetCommand : IRequest<Response<string>>
    {

        public long? StreetId { get; set; }

        public long? BusId { get; set; }

        public DateTime? DistributionDate { get; set; }

        public string? YearId { get; set; }


    }
}
