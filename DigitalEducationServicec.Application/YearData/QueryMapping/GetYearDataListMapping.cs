﻿using DigitalEducationServicec.Application.Features.YearData.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.YearData
{
    public partial class YearDataProfile
    {


        public void GetYearDataListMapping()
        {
            CreateMap<YearDataTb, GetYearDataListResponse>();


        }


    }
}
