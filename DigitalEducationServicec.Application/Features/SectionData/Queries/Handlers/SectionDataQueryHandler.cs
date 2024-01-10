using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.SectionData.Queries.Models;
using DigitalEducationServicec.Application.Features.SectionData.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.SectionData.Queries.Handlers
{
    public class SectionDataQueryHandler : ResponseHandler,
                                       IRequestHandler<GetSectionDataListQuery, Response<List<GetSectionDataListResponse>>>


    {

        private readonly IMapper _mapper;
        private readonly ISectionDataService _service;
        IStringLocalizer<SharedResources> _localizer;

        #region Constructors
        public SectionDataQueryHandler(ISectionDataService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        #region Handle Functions


        public async Task<Response<List<GetSectionDataListResponse>>> Handle(GetSectionDataListQuery request, CancellationToken cancellationToken)
        {
            var studentList = await _service.GetSectionDataListAsync();
            var studentListMapper = _mapper.Map<List<GetSectionDataListResponse>>(studentList);
            var result = Success(studentListMapper);
            result.Meta = new { Count = studentListMapper.Count() };
            return result;
        }
        #endregion

    }
}

