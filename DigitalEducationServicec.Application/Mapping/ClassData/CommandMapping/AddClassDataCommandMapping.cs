﻿using DigitalEducationServicec.Application.Features.ClassData.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.ClassData
{
    public partial class ClassDataProfile
    {
        public void AddClassDataCommandMapping()
        {
            CreateMap<AddClassDataCommand, ClassDataTb>();

        }
    }
}
