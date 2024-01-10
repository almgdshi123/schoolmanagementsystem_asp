using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.AcademicSystems.Queries.Models;
using DigitalEducationServicec.Application.Features.AcademicSystems.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.AcademicSystems.Queries.Handlers
{
    public class AcademicSystemsQueryHandler : ResponseHandler,
                                       IRequestHandler<GetAcademicSystemsListQuery, Response<List<GetAcademicSystemsListResponse>>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        private readonly IAcademicSystemService _service;

        #endregion

        #region Constructors
        public AcademicSystemsQueryHandler(IAcademicSystemService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<List<GetAcademicSystemsListResponse>>> Handle(GetAcademicSystemsListQuery request, CancellationToken cancellationToken)
        {
            var List = await _service.GetAcademicSystemsListAsync();
            var ListMapper = _mapper.Map<List<GetAcademicSystemsListResponse>>(List);
            var result = Success(ListMapper);
            result.Meta = new { Count = ListMapper.Count() };
            return result;
        }
        #endregion


    }
}
