using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DocmunetsClass.Queries.Models;
using DigitalEducationServicec.Application.Features.DocmunetsClass.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.DocmunetsClass.Queries.Handlers
{
    public class DocumentsClassQueryHandler : ResponseHandler, IRequestHandler<GetDocmumentsClassListQuery, Response<List<GetDocmunetsClassListResponse>>>
    {
        private readonly IDocmumentsClassService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public DocumentsClassQueryHandler(IDocmumentsClassService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<List<GetDocmunetsClassListResponse>>> Handle(GetDocmumentsClassListQuery request, CancellationToken cancellationToken)
        {
            var documentsClasses = await _service.GetDocmumentsClassListAsync();
            var documentsClassList = _mapper.Map<List<GetDocmunetsClassListResponse>>(documentsClasses);
            var result = Success(documentsClassList);
            result.Meta = new { Count = documentsClassList.Count() };
            return result;
        }
    }

}
