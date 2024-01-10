﻿using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.SectionData.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.SectionData.Commands.Handlers
{
    public class UpdateSectionDataCommandHandler : ResponseHandler,
                                       IRequestHandler<EditSectionDataCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ISectionDataService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public UpdateSectionDataCommandHandler(ISectionDataService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<string>> Handle(EditSectionDataCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var data = await _service.GetByIDAsync(request.SectionId);
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
