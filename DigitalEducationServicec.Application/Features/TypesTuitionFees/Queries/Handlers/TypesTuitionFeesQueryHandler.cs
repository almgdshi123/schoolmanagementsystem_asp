using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.AcademicDiscount.Queries.Results;
using DigitalEducationServicec.Application.Features.TypesTuitionFees.Queries.Models;
using DigitalEducationServicec.Application.Features.TypesTuitionFees.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Persistence.Abstracts;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.TypesTuitionFees.Queries.Handlers
{
    public class TypesTuitionFeesQueryHandler : ResponseHandler, IRequestHandler<GetTypesTuitionFeesListQuery, Response<List<GetTypesTuitionFeesListResponse>>>
    {
        private readonly IMapper _mapper;
        private readonly ITypesTuitionFeesService _service;

        private readonly IStringLocalizer<SharedResources> _localizer;



        public TypesTuitionFeesQueryHandler(ITypesTuitionFeesService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }



        public async Task<Response<List<GetTypesTuitionFeesListResponse>>> Handle(GetTypesTuitionFeesListQuery request, CancellationToken cancellationToken)
        {
            var List = await _service.GetTypesTuitionFeesListAsync();
            var ListMapper = _mapper.Map<List<GetTypesTuitionFeesListResponse>>(List);
            var result = Success(ListMapper);
            result.Meta = new { Count = ListMapper.Count() };
            return result;
        }
    }

}
