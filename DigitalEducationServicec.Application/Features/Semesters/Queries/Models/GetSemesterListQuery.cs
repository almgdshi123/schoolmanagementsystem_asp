using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.AcademicStatuses.Queries.Results;
using DigitalEducationServicec.Application.Features.Parent.Queries.Results;
using DigitalEducationServicec.Application.Features.Semesters.Queries.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEducationServicec.Application.Features.Semesters.Queries.Models
{
    public class GetSemesterListQuery : IRequest<Response<List<GetSemesterListResponse>>>
    {
    }
}
