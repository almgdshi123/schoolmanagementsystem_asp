using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Fines.Queries.Models;
using DigitalEducationServicec.Application.Features.Fines.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Fines.Queries.Handlers
{
    public class FinesQueryHandler : ResponseHandler, IRequestHandler<GetFinesListQuery, Response<List<GetFinesListResponse>>>
    {
        private readonly IFinesService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public FinesQueryHandler(IFinesService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        public async Task<Response<List<GetFinesListResponse>>> Handle(GetFinesListQuery request, CancellationToken cancellationToken)
        {
            var fines = await _service.GetFinesListAsync();
            var finesList = _mapper.Map<List<GetFinesListResponse>>(fines);
            var result = Success(finesList);
            result.Meta = new { Count = finesList.Count() };
            return result;
        }
    }

}
