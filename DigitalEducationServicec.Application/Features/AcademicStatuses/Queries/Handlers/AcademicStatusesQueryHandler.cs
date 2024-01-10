using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.AcademicStatuses.Queries.Models;
using DigitalEducationServicec.Application.Features.AcademicStatuses.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.AcademicStatuses.Queries.Handlers
{

    public class AcademicStatusesQueryHandler : ResponseHandler,
                                       IRequestHandler<GetAcademicStatusesListQuery, Response<List<GetAcademicStatusesListResponse>>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        private readonly IAcademicStatusService _service;

        #endregion

        #region Constructors
        public AcademicStatusesQueryHandler(IAcademicStatusService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<List<GetAcademicStatusesListResponse>>> Handle(GetAcademicStatusesListQuery request, CancellationToken cancellationToken)
        {
            var List = await _service.GetAcademicStatusesListAsync();
            var ListMapper = _mapper.Map<List<GetAcademicStatusesListResponse>>(List);
            var result = Success(ListMapper);
            result.Meta = new { Count = ListMapper.Count() };
            return result;
        }
        #endregion


    }
}
