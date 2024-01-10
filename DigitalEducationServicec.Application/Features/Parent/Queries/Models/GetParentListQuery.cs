using DigitalEducationServicec.Application.Features.Parent.Queries.Results;
using DigitalEducationServicec.Application.Features.Semesters.Queries.GetSemesterList;
using MediatR;
using System;
using DigitalEducationServicec.Application.Bases;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEducationServicec.Application.Features.Parent.Queries.Models
{
    public class GetParentListQuery  : IRequest<Response<List<GetParentListResponse>>>
    {
    }
    
    
}
