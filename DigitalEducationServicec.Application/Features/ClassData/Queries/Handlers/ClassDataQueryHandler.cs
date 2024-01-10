using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.ClassData.Queries.Models;
using DigitalEducationServicec.Application.Features.ClassData.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.ClassData.Queries.Handlers
{
    public class ClassDataQueryHandler : ResponseHandler,
                                       IRequestHandler<GetClassDataListQuery, Response<List<GetClassDataListResponse>>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IClassDataService _service;

        #endregion
        private readonly IStringLocalizer<SharedResources> _localizer;



        #region Constructors
        public ClassDataQueryHandler(IClassDataService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }


        public async Task<Response<List<GetClassDataListResponse>>> Handle(GetClassDataListQuery request, CancellationToken cancellationToken)
        {
            var List = await _service.GetListAsync();
            var ListMapper = _mapper.Map<List<GetClassDataListResponse>>(List);
            var result = Success(ListMapper);
            result.Meta = new { Count = ListMapper.Count() };
            return result;
        }
        #endregion



    }
}
