using DigitalEducationServicec.Application.Features.AcademicStatuses.Queries.Results;
using DigitalEducationServicec.Application.Features.Parent.Queries.Results;
using DigitalEducationServicec.Application.Features.Semesters.Queries.Results;
using DigitalEducationServicec.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEducationServicec.Application.Mapping.Parent
{
    public partial class ParentProfile
    {
        public void GetParentListMapping()
        {
            CreateMap<ParentTb , GetParentListResponse>();
        }
    }
}
