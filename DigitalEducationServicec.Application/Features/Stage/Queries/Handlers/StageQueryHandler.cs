using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Stage.Queries.Models;
using DigitalEducationServicec.Application.Features.Stage.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Stage.Queries.Handlers
{
    public class StageQueryHandler : ResponseHandler,
                                       IRequestHandler<GetStageListQuery, Response<List<GetStageListResponse>>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStageService _service;
        IStringLocalizer<SharedResources> _localizer;
        #endregion

        #region Constructors
        public StageQueryHandler(IStageService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        public async Task<Response<List<GetStageListResponse>>> Handle(GetStageListQuery request, CancellationToken cancellationToken)
        {
            var List = await _service.GetStageTbListAsync();
            var ListMapper = _mapper.Map<List<GetStageListResponse>>(List);
            var result = Success(ListMapper);
            result.Meta = new { Count = ListMapper.Count() };
            return result;
        }
        #endregion

    }
}
