using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.ClassTuitionFees.Queries.Models;
using DigitalEducationServicec.Application.Features.ClassTuitionFees.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.ClassTuitionFees.Queries.Handlers
{
    public class ClassTuitionFeesQueryHandler : ResponseHandler, IRequestHandler<GetClassTuitionFeesListQuery, Response<List<GetClassTuitionFeesListResponse>>>
    {
        private readonly IClassTuitionFeesService _service;

        private readonly IStringLocalizer<SharedResources> _localizer;
        private readonly IMapper _mapper;

        public ClassTuitionFeesQueryHandler(IClassTuitionFeesService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }


        public async Task<Response<List<GetClassTuitionFeesListResponse>>> Handle(GetClassTuitionFeesListQuery request, CancellationToken cancellationToken)
        {
            var fees = await _service.GetClassTuitionFeesListAsync();
            var feesList = _mapper.Map<List<GetClassTuitionFeesListResponse>>(fees);
            var result = new Response<List<GetClassTuitionFeesListResponse>>(feesList);
            result.Meta = new { Count = feesList.Count() };
            return result;
        }
    }

}
