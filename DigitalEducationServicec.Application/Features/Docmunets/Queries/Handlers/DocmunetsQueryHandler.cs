using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Docmunets.Queries.Models;
using DigitalEducationServicec.Application.Features.Docmunets.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Docmunets.Queries.Handlers
{
    public class DocumentsQueryHandler : ResponseHandler, IRequestHandler<GetDocmunetsListQuery, Response<List<GetDocmunetsListResponse>>>
    {
        private readonly IDocmumentsService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public DocumentsQueryHandler(IDocmumentsService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        public async Task<Response<List<GetDocmunetsListResponse>>> Handle(GetDocmunetsListQuery request, CancellationToken cancellationToken)
        {
            var documents = await _service.GetDocmumentsListAsync();
            var documentsList = _mapper.Map<List<GetDocmunetsListResponse>>(documents);
            var result = Success(documentsList);
            result.Meta = new { Count = documentsList.Count() };
            return result;
        }
    }

}
