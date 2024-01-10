using Azure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEducationServicec.Application.Features.Semesters.Commands.CreateSemester
{
    public class CreateSemesterCommand : IRequest<string>
    {
        public string? SemesterName { get; set; }

    }
}
