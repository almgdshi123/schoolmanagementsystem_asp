﻿using DigitalEducationServicec.Application.Features.Installment.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Installment
{
    public partial class InstallmentProfile
    {
        public void EditInstallmentCommandMapping()
        {
            CreateMap<EditInstallmentCommand, InstallmentTb>();
        }
    }

}
