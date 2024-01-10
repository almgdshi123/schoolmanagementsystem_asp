using DigitalEducationServicec.Application.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEducationServicec.Application.Features.AcademicStatuses.Commands.Models
{
    public class DeleteAcademicStatusCommand : IRequest<Response<string>>
    {
        public long StatusId { get; set; }

    }
}
