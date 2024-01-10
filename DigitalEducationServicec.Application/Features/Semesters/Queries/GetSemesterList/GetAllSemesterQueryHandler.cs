using AutoMapper;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Semesters.Queries.GetSemesterList
{
    public class GetAllSemesterQueryHandler : IRequestHandler<GetAllSemeterQuery, List<SemesterViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly ISemesterService _semesterService;

        public GetAllSemesterQueryHandler(IMapper mapper, ISemesterService semesterService)
        {
            _mapper = mapper;
            _semesterService = semesterService;

        }

        public Task<List<SemesterViewModel>> Handle(GetAllSemeterQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
