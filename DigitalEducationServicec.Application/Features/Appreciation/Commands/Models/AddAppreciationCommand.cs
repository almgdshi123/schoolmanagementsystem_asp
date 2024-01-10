using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Appreciation.Commands.Models
{
    public class AddAppreciationCommand : IRequest<Response<string>>
    {

        public string? AppreciationName { get; set; }

        public string? AppreciationNameEn { get; set; }

        public string? LowScore { get; set; }

        public string? HighScore { get; set; }
    }
}
