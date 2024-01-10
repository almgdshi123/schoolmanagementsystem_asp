﻿using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Homework.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Homework.Commands.Handlers
{
    public class DeleteHomeworkCommandHandler : ResponseHandler,
                                       IRequestHandler<DeleteHomeworkCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IHomeworkService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public DeleteHomeworkCommandHandler(IHomeworkService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<string>> Handle(DeleteHomeworkCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var data = await _service.GetByIDAsync(request.HomeworkId);
            //return NotFound
            if (data == null) return NotFound<string>();
            //Call service that make Delete
            var result = await _service.DeleteAsync(data);
            if (result == "Success") return Deleted<string>();
            else return BadRequest<string>();
        }
    }
}


