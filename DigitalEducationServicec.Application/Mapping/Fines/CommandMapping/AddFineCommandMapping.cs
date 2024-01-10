﻿using DigitalEducationServicec.Application.Features.Fines.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Fines
{

    public partial class FinesProfile
    {


        public void AddFineCommandMapping()
        {
            CreateMap<AddFinesCommand, FinesTb>();
        }
    }
}
