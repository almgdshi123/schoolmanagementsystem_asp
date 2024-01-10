using DigitalEducationServicec.Application.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEducationServicec.Application.Features.Semesters.Commands.Validatiors
{
    internal class AddSemesterValidator : IRequest<Response<string>>
    {
        public string? SemesterName { get; set; }
    }
}
