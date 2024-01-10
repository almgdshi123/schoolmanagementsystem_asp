using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DistributionSubTeacher.Queries.Models;
using DigitalEducationServicec.Application.Features.DistributionSubTeacher.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.DistributionSubTeacher.Queries.Handlers
{
    internal class DistributionSubTeacherQueryHandler : ResponseHandler,
                                       IRequestHandler<GetDistributionSubTeacherListQuery, Response<List<GetDistributionSubTeacherListResponse>>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        private readonly IDistributionSubTeacherService _service;

        #endregion

        #region Constructors
        public DistributionSubTeacherQueryHandler(IDistributionSubTeacherService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<List<GetDistributionSubTeacherListResponse>>> Handle(GetDistributionSubTeacherListQuery request, CancellationToken cancellationToken)
        {
            var List = await _service.GetByIDAsync(1);
            var ListMapper = _mapper.Map<List<GetDistributionSubTeacherListResponse>>(List);
            var result = Success(ListMapper);
            result.Meta = new { Count = ListMapper.Count() };
            return result;
        }
    }
}
