using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.DistributionClassSub.Commands.Models
{
    public class AddDistributionClassSubCommand : IRequest<Response<string>>
    {

        public long ClassId { get; set; }

        public string? ClassCode { get; set; }

        public long? SubjectId { get; set; }

        public string? Note { get; set; }

    }
}
