using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.YearData.Commands.Models
{
    public class DeleteYearDataCommand : IRequest<Response<string>>
    {
        public string YearId { get; set; } = null!;


    }
}
