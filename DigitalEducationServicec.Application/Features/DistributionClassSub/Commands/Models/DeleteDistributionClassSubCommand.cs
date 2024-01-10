using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DistributionClassSub.Commands.Models
{
    public class DeleteDistributionClassSubCommand : IRequest<Response<string>>
    {
        public long DistrClassSubId { get; set; }



    }
}
