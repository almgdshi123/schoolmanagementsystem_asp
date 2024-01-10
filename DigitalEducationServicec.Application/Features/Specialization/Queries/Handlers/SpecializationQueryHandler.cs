using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Specialization.Queries.Models;
using DigitalEducationServicec.Application.Features.Specialization.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Specialization.Queries.Handlers
{
    public class SpecializationQueryHandler : ResponseHandler,
                                       IRequestHandler<GetSpecializationListQuery, Response<List<GetSpecializationListResponse>>>


    {

        private readonly IMapper _mapper;
        private readonly ISpecializationService _service;
        IStringLocalizer<SharedResources> _localizer;

        #region Constructors
        public SpecializationQueryHandler(ISpecializationService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        #region Handle Functions


        public async Task<Response<List<GetSpecializationListResponse>>> Handle(GetSpecializationListQuery request, CancellationToken cancellationToken)
        {
            var studentList = await _service.GetSpecializationListAsync();
            var studentListMapper = _mapper.Map<List<GetSpecializationListResponse>>(studentList);
            var result = Success(studentListMapper);
            result.Meta = new { Count = studentListMapper.Count() };
            return result;
        }

        #endregion

    }
}
