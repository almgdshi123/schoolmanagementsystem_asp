using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.Fines.Commands.Models
{
    public class DeleteFinesCommand : IRequest<Response<string>>
    {
        public long FinesId { get; set; }


    }
}
