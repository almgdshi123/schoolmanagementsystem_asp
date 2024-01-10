using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Parent.Queries.Models;
using DigitalEducationServicec.Application.Features.Parent.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Parent.Queries.Handlers
{
    public class ParentQueryHandler : ResponseHandler,
                                       IRequestHandler<GetParentListQuery, Response<List<GetParentListResponse>>>

    {

        private readonly IMapper _mapper;
        private readonly IParentService _service;
        IStringLocalizer<SharedResources> _localizer;

        #region Constructors
        public ParentQueryHandler(IParentService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        #region Handle Functions

        public async Task<Response<List<GetParentListResponse>>> Handle(GetParentListQuery request, CancellationToken cancellationToken)
        {
            var studentList = await _service.GetParentListAsync();
            var studentListMapper = _mapper.Map<List<GetParentListResponse>>(studentList);
            var result = Success(studentListMapper);
            result.Meta = new { Count = studentListMapper.Count() };
            return result;
        }

        //public async Task<Response<GetSingleStudentResponse>> Handle(GetStudentByIDQuery request, CancellationToken cancellationToken)
        //{
        //    var student = await _studentService.GetStudentByIDWithIncludeAsync(request.Id);
        //    if (student == null) return NotFound<GetSingleStudentResponse>(_stringLocalizer[SharedResourcesKeys.NotFound]);
        //    var result = _mapper.Map<GetSingleStudentResponse>(student);
        //    return Success(result);
        //}

        //public async Task<PaginatedResult<GetStudentPaginatedListResponse>> Handle(GetStudentPaginatedListQuery request, CancellationToken cancellationToken)
        //{
        //    //Expression<Func<Student, GetStudentPaginatedListResponse>> expression = e => new GetStudentPaginatedListResponse(e.StudID, e.Localize(e.NameAr, e.NameEn), e.Address, e.Department.Localize(e.Department.DNameAr, e.Department.DNameEn));
        //    var FilterQuery = _studentService.FilterStudentPaginatedQuerable(request.OrderBy, request.Search);
        //    var PaginatedList = await _mapper.ProjectTo<GetStudentPaginatedListResponse>(FilterQuery).ToPaginatedListAsync(request.PageNumber, request.PageSize);
        //    PaginatedList.Meta = new { Count = PaginatedList.Data.Count() };
        //    return PaginatedList;
        //}

        #endregion
    }
}