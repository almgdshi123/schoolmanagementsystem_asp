using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Preparation.Commands.Models
{
    public class AddPreparationCommand : IRequest<Response<string>>
    {

        public long? FileStudentId { get; set; }

        public long? DistrSubTeacherId { get; set; }

        public long? MonthAcademicId { get; set; }

        public DateTime? PreparationDate { get; set; }

        public int? Status { get; set; }

        public string? Note { get; set; }
    }
}
