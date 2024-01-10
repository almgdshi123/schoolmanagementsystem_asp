using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEducationServicec.Application.Features.Semesters.Queries.GetSemesterList
{
    public class GetAllSemeterQuery : IRequest<List<SemesterViewModel>>
    {
    }
}