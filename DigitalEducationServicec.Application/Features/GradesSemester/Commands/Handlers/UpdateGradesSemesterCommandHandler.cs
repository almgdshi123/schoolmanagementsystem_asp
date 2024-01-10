﻿using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.GradesSemester.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.GradesSemester.Commands.Handlers
{
    public class UpdateGradesSemesterCommandHandler : ResponseHandler,
                                       IRequestHandler<EditGradesSemesterCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IGradesSemesterService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public UpdateGradesSemesterCommandHandler(IGradesSemesterService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<string>> Handle(EditGradesSemesterCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var data = await _service.GetByIDAsync(request.GradesSemesterId);
            //return NotFound
            if (data == null) return NotFound<string>();
            //mapping Between request and data
            var datamapper = _mapper.Map(request, data);
            //Call service that make Edit
            var result = await _service.EditAsync(datamapper);
            //return response
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Updated]);
            else return BadRequest<string>(_localizer[SharedResourcesKeys.Updated]);
        }
    }
}

