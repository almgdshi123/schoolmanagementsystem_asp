using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEducationServicec.Application.Features.Parent.Queries.Results
{
    public class GetParentListResponse
    {
        public long ParentId { get; set; }

        public string? ParentName { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }

        public string? Gender { get; set; }
    }
}
