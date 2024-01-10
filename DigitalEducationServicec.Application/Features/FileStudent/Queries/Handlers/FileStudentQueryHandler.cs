using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.FileStudent.Queries.Models;
using DigitalEducationServicec.Application.Features.FileStudent.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.FileStudent.Queries.Handlers
{
    public class FileStudentQueryHandler : ResponseHandler,
                                       IRequestHandler<GetFileStudentListQuery, Response<List<GetFileStudentListResponse>>>


    {
        #region Fields
        private readonly IFileStudentService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        #endregion

        #region Constructors
        public FileStudentQueryHandler(IFileStudentService service,
                                     IMapper mapper,
                                     IStringLocalizer<SharedResources> localizer) : base(localizer)
        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<Response<List<GetFileStudentListResponse>>> Handle(GetFileStudentListQuery request, CancellationToken cancellationToken)
        {
            var List = await _service.GetFileStudentListAsync();
            var ListMapper = _mapper.Map<List<GetFileStudentListResponse>>(List);
            var result = Success(ListMapper);
            result.Meta = new { Count = ListMapper.Count() };
            return result;
        }
        #endregion



    }
}
