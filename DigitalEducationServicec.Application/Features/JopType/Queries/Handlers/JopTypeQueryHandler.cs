using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.JopType.Queries.Models;
using DigitalEducationServicec.Application.Features.JopType.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.JopType.Queries.Handlers
{
    public class JobTypeQueryHandler : ResponseHandler, IRequestHandler<GetJopTypeListQuery, Response<List<GetJopTypeListResponse>>>
    {
        private readonly IJopTypeService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public JobTypeQueryHandler(IJopTypeService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<List<GetJopTypeListResponse>>> Handle(GetJopTypeListQuery request, CancellationToken cancellationToken)
        {
            var jobTypes = await _service.GetJopTypeListAsync();
            var jobTypeList = _mapper.Map<List<GetJopTypeListResponse>>(jobTypes);
            var result = Success(jobTypeList);
            result.Meta = new { Count = jobTypeList.Count() };
            return result;
        }
    }

}
