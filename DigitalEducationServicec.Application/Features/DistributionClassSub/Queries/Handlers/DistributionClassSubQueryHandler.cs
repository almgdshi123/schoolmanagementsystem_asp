using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DistributionClassSub.Queries.Models;
using DigitalEducationServicec.Application.Features.DistributionClassSub.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.DistributionClassSub.Queries.Handlers
{
    public class DistributionClassSubQueryHandler : ResponseHandler,
                                       IRequestHandler<GetDistributionClassSubListQuery, Response<List<GetDistributionClassSubListResponse>>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        private readonly IDistributionClassSubService _service;

        #endregion

        #region Constructors
        public DistributionClassSubQueryHandler(IDistributionClassSubService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<List<GetDistributionClassSubListResponse>>> Handle(GetDistributionClassSubListQuery request, CancellationToken cancellationToken)
        {
            var List = await _service.GeDistributionClassSubListAsync();
            var ListMapper = _mapper.Map<List<GetDistributionClassSubListResponse>>(List);
            var result = Success(ListMapper);
            result.Meta = new { Count = ListMapper.Count() };
            return result;
        }
    }
}
