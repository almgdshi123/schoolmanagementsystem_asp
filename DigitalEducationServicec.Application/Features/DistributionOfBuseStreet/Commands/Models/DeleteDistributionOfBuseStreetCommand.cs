using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.DistributionOfBuseStreet.Commands.Models
{
    public class DeleteDistributionOfBuseStreetCommand : IRequest<Response<string>>
    {
        public long DistributionOfBuseStreetId { get; set; }



    }
}
