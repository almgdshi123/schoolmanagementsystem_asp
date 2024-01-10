using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.SemesterAcademic.Commands.Models
{
    public class DeleteSemesterAcademicCommand : IRequest<Response<string>>
    {
        public long SemesterAcademicId { get; set; }



    }
}
