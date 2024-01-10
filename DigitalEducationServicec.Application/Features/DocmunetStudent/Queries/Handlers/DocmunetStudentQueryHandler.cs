using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DocmunetStudent.Queries.Models;
using DigitalEducationServicec.Application.Features.DocmunetStudent.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.DocmunetStudent.Queries.Handlers
{
    public class DocumentStudentQueryHandler : ResponseHandler, IRequestHandler<GetDocmunetStudentListQuery, Response<List<GetDocmunetStudentListResponse>>>
    {
        private readonly IDocmunetStudentService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public DocumentStudentQueryHandler(IDocmunetStudentService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        public async Task<Response<List<GetDocmunetStudentListResponse>>> Handle(GetDocmunetStudentListQuery request, CancellationToken cancellationToken)
        {
            var documents = await _service.GetDocmunetStudentListAsync();
            var documentList = _mapper.Map<List<GetDocmunetStudentListResponse>>(documents);
            var result = Success(documentList);
            result.Meta = new { Count = documentList.Count() };
            return result;
        }
    }

}
