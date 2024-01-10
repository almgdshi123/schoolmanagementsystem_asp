using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DistributionSubTeacher.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.DistributionSubTeacher.Commands.Handlers
{
    public class CreateDistributionSubTeacherCommandHandler : ResponseHandler,
                                       IRequestHandler<AddDistributionSubTeacherCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        private readonly IDistributionSubTeacherService _service;

        #endregion

        #region Constructors
        public CreateDistributionSubTeacherCommandHandler(IDistributionSubTeacherService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<string>> Handle(AddDistributionSubTeacherCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and DistributionSubTeacherTb
            var DistributionSubTeacher = _mapper.Map<DistributionSubTeacherTb>(request);
            //add
            var result = await _service.AddAsync(DistributionSubTeacher);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>(_localizer[SharedResourcesKeys.BadRequest]);
        }
    }
}
