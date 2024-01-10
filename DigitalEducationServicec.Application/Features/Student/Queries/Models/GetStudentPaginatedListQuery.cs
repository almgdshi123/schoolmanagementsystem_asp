using DigitalEducationServicec.Application.Features.Student.Queries.Results;
using DigitalEducationServicec.Application.Wrappers;
using DigitalEducationServicec.Domain.Helpers;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Student.Queries.Models
{
    public class GetStudentPaginatedListQuery : IRequest<PaginatedResult<GetStudentPaginatedListResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public StudentOrderingEnum OrderBy { get; set; }
        public string? Search { get; set; }
    }
}
