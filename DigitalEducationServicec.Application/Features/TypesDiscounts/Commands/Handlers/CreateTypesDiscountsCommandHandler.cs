﻿using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.TypesDiscounts.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.TypesDiscounts.Commands.Handlers
{
    public class CreateTypesDiscountsCommandHandler : ResponseHandler,
                                                      IRequestHandler<AddTypesDiscountsCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ITypesDiscountsService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateTypesDiscountsCommandHandler(ITypesDiscountsService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddTypesDiscountsCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and TypesDiscountsTb
            var data = _mapper.Map<TypesDiscountsTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}
