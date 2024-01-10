using DigitalEducationServicec.Application.Features.ClassData.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.ClassData.Commands.Validatiors
{
    public class AddClassDataValidator : AbstractValidator<AddClassDataCommand>
    {

        #region Fields
        private readonly IClassDataService _studentService;
        private readonly IStringLocalizer<SharedResources> _localizer;
        #endregion

        #region Constructors
        public AddClassDataValidator(IClassDataService studentService,
                                   IStringLocalizer<SharedResources> localizer
                                 )
        {
            _studentService = studentService;
            _localizer = localizer;
            ApplyValidationsRules();
            // ApplyCustomValidationsRules();
        }
        #endregion

        #region Actions
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.ClassName)
                 .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                 .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required])
                 .MaximumLength(100).WithMessage(_localizer[SharedResourcesKeys.MaxLengthis100]);

            RuleFor(x => x.ClassCode)
                .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required])
                .MaximumLength(100).WithMessage(_localizer[SharedResourcesKeys.MaxLengthis100]);

            RuleFor(x => x.StageId)
                 .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
                 .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);
        }

        //public void ApplyCustomValidationsRules()
        //{
        //    RuleFor(x => x.NameAr)
        //        .MustAsync(async (Key, CancellationToken) => !await _studentService.IsNameArExist(Key))
        //        .WithMessage(_localizer[SharedResourcesKeys.IsExist]);
        //    RuleFor(x => x.NameEn)
        //       .MustAsync(async (Key, CancellationToken) => !await _studentService.IsNameEnExist(Key))
        //       .WithMessage(_localizer[SharedResourcesKeys.IsExist]);



        //    RuleFor(x => x.StageId)
        //   .MustAsync(async (Key, CancellationToken) => await _departmentService.IsDepartmentIdExist(Key))
        //   .WithMessage(_localizer[SharedResourcesKeys.IsNotExist]);




        //}

        #endregion

    }
}
