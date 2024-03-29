﻿using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.TypeOfActivities.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.TypeOfActivities.Commands.Handlers
{
    public class CreateTypeOfActivitiesCommandHandler : ResponseHandler,
                                                     IRequestHandler<AddTypeOfActivitiesCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ITypeOfActivitiesService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateTypeOfActivitiesCommandHandler(ITypeOfActivitiesService service,
                                                 IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddTypeOfActivitiesCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and TypeOfActivitiesTb
            var data = _mapper.Map<TypeOfActivitiesTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}