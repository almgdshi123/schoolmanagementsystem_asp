using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.FileStudent.Commands.Models
{
    public class AddFileStudentCommand : IRequest<Response<string>>
    {

        public long? StudentId { get; set; }

        public long? FinancialNumber { get; set; }

        public string? YearId { get; set; }

        public DateTime? RenewalDate { get; set; }

        public long? SectionId { get; set; }

        public long? StatusId { get; set; }

        public long? SystemId { get; set; }

        public int? Status { get; set; }

        public string? Note { get; set; }
    }
}
