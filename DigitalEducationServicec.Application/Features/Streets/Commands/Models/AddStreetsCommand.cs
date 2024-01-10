using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Streets.Commands.Models
{
    public class AddStreetsCommand : IRequest<Response<string>>
    {
    }
}
