using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.StudentActivitie.Queries.Models;
using DigitalEducationServicec.Application.Features.StudentActivitie.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.StudentActivitie.Queries.Handlers
{
    public class StudentActivityQueryHandler : ResponseHandler, IRequestHandler<GetStudentActivitieListQuery, Response<List<GetStudentActivitieListResponse>>>
    {
        private readonly IStudentActivitieService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public StudentActivityQueryHandler(IStudentActivitieService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<List<GetStudentActivitieListResponse>>> Handle(GetStudentActivitieListQuery request, CancellationToken cancellationToken)
        {
            var activities = await _service.GetStudentActivitieListAsync();
            var activityList = _mapper.Map<List<GetStudentActivitieListResponse>>(activities);
            var result = Success(activityList);
            result.Meta = new { Count = activityList.Count() };
            return result;
        }
    }

}
