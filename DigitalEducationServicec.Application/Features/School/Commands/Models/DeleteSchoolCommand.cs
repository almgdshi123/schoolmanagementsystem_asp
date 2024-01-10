using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.School.Commands.Models
{
    public class DeleteSchoolCommand : IRequest<Response<string>>
    {
    }
}
