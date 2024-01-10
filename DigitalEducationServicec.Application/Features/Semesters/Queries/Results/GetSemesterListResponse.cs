using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEducationServicec.Application.Features.Semesters.Queries.Results
{
    public class GetSemesterListResponse
    {
        public long SemesterId { get; set; }
        public string? SemesterName { get; set; }
    }
}
