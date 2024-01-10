using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.YearData.Queries.Models;
using DigitalEducationServicec.Application.Features.YearData.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.YearData.Queries.Handlers
{
    public class YearDataQueryHandler : ResponseHandler,
                                       IRequestHandler<GetYearDataListQuery, Response<List<GetYearDataListResponse>>>


    {
        #region Fields
        private readonly IYearDataService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        #endregion

        #region Constructors
        public YearDataQueryHandler(IYearDataService service,
                                     IMapper mapper,
                                     IStringLocalizer<SharedResources> localizer) : base(localizer)
        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;
        }
        #endregion


        public async Task<Response<List<GetYearDataListResponse>>> Handle(GetYearDataListQuery request, CancellationToken cancellationToken)
        {
            var List = await _service.GetYearDataListAsync();
            var ListMapper = _mapper.Map<List<GetYearDataListResponse>>(List);
            var result = Success(ListMapper);
            result.Meta = new { Count = ListMapper.Count() };
            return result;
        }
    }
}
