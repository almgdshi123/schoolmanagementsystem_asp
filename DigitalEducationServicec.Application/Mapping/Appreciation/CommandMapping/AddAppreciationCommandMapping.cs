﻿using DigitalEducationServicec.Application.Features.Appreciation.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Appreciation
{
    public partial class AppreciationProfile
    {


        public void AddAppreciationCommandMapping()
        {
            CreateMap<AddAppreciationCommand, AppreciationTb>();
        }
    }
}
