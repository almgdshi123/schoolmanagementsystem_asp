﻿using DigitalEducationServicec.Application.Features.ClassTuitionFees.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.ClassTuitionFees
{
    public partial class ClassTuitionFeesProfile
    {
        public void ClassTuitionFeesListMapping()
        {
            CreateMap<ClassTuitionFeesTb, GetClassTuitionFeesListResponse>();
        }
    }
}
