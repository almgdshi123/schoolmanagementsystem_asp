using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.MonthAcademic.Commands.Models
{
    public class DeleteMonthAcademicCommand : IRequest<Response<string>>
    {
        public long MonthAcademicId { get; set; }


    }
}
