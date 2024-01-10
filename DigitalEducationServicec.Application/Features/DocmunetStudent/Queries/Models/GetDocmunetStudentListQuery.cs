using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DocmunetStudent.Queries.Results;
using MediatR;


namespace DigitalEducationServicec.Application.Features.DocmunetStudent.Queries.Models
{
    public class GetDocmunetStudentListQuery : IRequest<Response<List<GetDocmunetStudentListResponse>>>
    {
    }
}
