using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.AcademicDiscount.Queries.Models;
using DigitalEducationServicec.Application.Features.AcademicDiscount.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.AcademicDiscount.Queries.Handlers
{
    public class AcademicDiscountQueryHandler : ResponseHandler,
                                           IRequestHandler<GetAcademicDiscountListQuery, Response<List<GetAcademicDiscountListResponse>>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IAcademicDiscountService _service;

        #endregion
        private readonly IStringLocalizer<SharedResources> _localizer;



        #region Constructors
        public AcademicDiscountQueryHandler(IAcademicDiscountService service,
                                           IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }


        public async Task<Response<List<GetAcademicDiscountListResponse>>> Handle(GetAcademicDiscountListQuery request, CancellationToken cancellationToken)
        {
            var List = await _service.GetAcademicDiscountListAsync();
            var ListMapper = _mapper.Map<List<GetAcademicDiscountListResponse>>(List);
            var result = Success(ListMapper);
            result.Meta = new { Count = ListMapper.Count() };
            return result;
        }
        #endregion



    }
}
