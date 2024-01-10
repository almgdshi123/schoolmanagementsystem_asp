using Azure;
using MediatR;

namespace DigitalEducationServicec.Application.Features.UserData.Commands.Models
{
    public class DeleteUserDataCommand : IRequest<Response<string>>
    {
    }
}
