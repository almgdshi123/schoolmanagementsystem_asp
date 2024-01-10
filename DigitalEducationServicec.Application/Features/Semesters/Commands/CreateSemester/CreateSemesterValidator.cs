using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEducationServicec.Application.Features.Semesters.Commands.CreateSemester
{
    public class CreateSemesterValidator : AbstractValidator<CreateSemesterCommand>
    {
        public CreateSemesterValidator()
        {
            RuleFor(p => p.SemesterName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);

        }
    }
}
