using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.UserData.Commands.Models
{
    public class EditUserDataCommand : IRequest<Response<string>>
    {
    }
}
