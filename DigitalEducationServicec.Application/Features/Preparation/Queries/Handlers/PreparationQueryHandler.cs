using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Preparation.Queries.Models;
using DigitalEducationServicec.Application.Features.Preparation.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Preparation.Queries.Handlers
{
    public class PreparationQueryHandler : ResponseHandler,
                                       IRequestHandler<GetPreparationListQuery, Response<List<GetPreparationListResponse>>>


    {

        private readonly IMapper _mapper;
        private readonly IPreparationService _service;
        IStringLocalizer<SharedResources> _localizer;

        #region Constructors
        public PreparationQueryHandler(IPreparationService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        #region Handle Functions


        public async Task<Response<List<GetPreparationListResponse>>> Handle(GetPreparationListQuery request, CancellationToken cancellationToken)
        {
            var preparationList = await _service.GetPreparationListAsync();
            var preparationListMapper = _mapper.Map<List<GetPreparationListResponse>>(preparationList);
            var result = Success(preparationListMapper);
            result.Meta = new { Count = preparationListMapper.Count() };
            return result;
        }
        #endregion

    }
}

