using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.SectionCode.Queries.Models;
using DigitalEducationServicec.Application.Features.SectionCode.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.SectionCode.Queries.Handlers
{
    public class SectionCodeQueryHandler : ResponseHandler, IRequestHandler<GetSectionCodeListQuery, Response<List<GetSectionCodeListResponse>>>
    {
        private readonly ISectionCodeService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public SectionCodeQueryHandler(ISectionCodeService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<List<GetSectionCodeListResponse>>> Handle(GetSectionCodeListQuery request, CancellationToken cancellationToken)
        {
            var sectionCodes = await _service.GetSectionCodeListAsync();
            var sectionCodeList = _mapper.Map<List<GetSectionCodeListResponse>>(sectionCodes);
            var result = Success(sectionCodeList);
            result.Meta = new { Count = sectionCodeList.Count() };
            return result;
        }
    }

}
