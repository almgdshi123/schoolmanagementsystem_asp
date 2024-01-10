using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.ClassTuitionFees.Commands.Models
{
    public class EditClassTuitionFeesCommand : IRequest<Response<string>>
    {
        public long ClassTuitionFeesId { get; set; }

        public string? ClassTuitionFeesName { get; set; }

        public string? ClassTuitionFeesType { get; set; }

        public long? TypesTuitionFeesId { get; set; }

        public decimal? Amount { get; set; }

        public long? ClassId { get; set; }

        public string? YearId { get; set; }


    }
}
