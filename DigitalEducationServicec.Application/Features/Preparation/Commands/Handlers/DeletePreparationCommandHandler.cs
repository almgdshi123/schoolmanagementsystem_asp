﻿using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Preparation.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Preparation.Commands.Handlers
{
    public class DeletePreparationCommandHandler : ResponseHandler,
                                       IRequestHandler<DeletePreparationCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IPreparationService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public DeletePreparationCommandHandler(IPreparationService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion



        public async Task<Response<string>> Handle(DeletePreparationCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var data = await _service.GetByIDAsync(request.PreparationId);
            //return NotFound
            if (data == null) return NotFound<string>();
            //Call service that make Delete
            var result = await _service.DeleteAsync(data);
            if (result == "Success") return Deleted<string>();
            else return BadRequest<string>();
        }
    }
}


