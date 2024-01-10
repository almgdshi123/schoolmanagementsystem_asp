﻿using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Parent.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Parent.Commands.Handlers
{
    public class CreateParentCommandHandler : ResponseHandler,
                                       IRequestHandler<AddParentCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IParentService _service;

        #endregion

        #region Constructors
        public CreateParentCommandHandler(IParentService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            // _localizer = localizer;

        }

        #endregion


        #region Handle Functions

        public async Task<Response<string>> Handle(AddParentCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and student
            var parentMapper = _mapper.Map<ParentTb>(request);
            //add
            var result = await _service.AddAsync(parentMapper);
            //return response
            if (result == "Success") return Created("");
            else return BadRequest<string>();
        }

        //public async Task<Response<string>> Handle(EditStudentCommand request, CancellationToken cancellationToken)
        //{
        //    //Check if the Id is Exist Or not
        //    var student = await _studentService.GetByIDAsync(request.Id);
        //    //return NotFound
        //    if (student == null) return NotFound<string>();
        //    //mapping Between request and student
        //    var studentmapper = _mapper.Map(request, student);
        //    //Call service that make Edit
        //    var result = await _studentService.EditAsync(studentmapper);
        //    //return response
        //    //return response
        //    if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Updated]);
        //    else return BadRequest<string>();
        //}

        //public async Task<Response<string>> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        //{
        //    //Check if the Id is Exist Or not
        //    var student = await _studentService.GetByIDAsync(request.Id);
        //    //return NotFound
        //    if (student == null) return NotFound<string>();
        //    //Call service that make Delete
        //    var result = await _studentService.DeleteAsync(student);
        //    if (result == "Success") return Deleted<string>();
        //    else return BadRequest<string>();
        //}
        #endregion

    }
}

