using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.TypesDiscounts.Queries.Models;
using DigitalEducationServicec.Application.Features.TypesDiscounts.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.TypesDiscounts.Queries.Handlers
{
    public class TypesDiscountsQueryHandler : ResponseHandler, IRequestHandler<GetTypesDiscountsListQuery, Response<List<GetTypesDiscountsListResponse>>>
    {
        private readonly ITypesDiscountsService _service;

        private readonly IStringLocalizer<SharedResources> _localizer;



        private readonly IMapper _mapper;

        public TypesDiscountsQueryHandler(ITypesDiscountsService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }


        public async Task<Response<List<GetTypesDiscountsListResponse>>> Handle(GetTypesDiscountsListQuery request, CancellationToken cancellationToken)
        {
            var typesDiscounts = await _service.GetTypesDiscountsListAsync();
            var typesDiscountsList = _mapper.Map<List<GetTypesDiscountsListResponse>>(typesDiscounts);
            var result = Success(typesDiscountsList);
            result.Meta = new { Count = typesDiscountsList.Count() };
            return result;
        }
    }

}
