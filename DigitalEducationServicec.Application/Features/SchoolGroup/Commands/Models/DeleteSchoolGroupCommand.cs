using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.SchoolGroup.Commands.Models
{
    public class DeleteSchoolGroupCommand : IRequest<Response<string>>
    {
    }
}
