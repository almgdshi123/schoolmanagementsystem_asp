﻿using DigitalEducationServicec.Application.Features.ParticiStudentActiv.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.ParticiStudentActiv
{
    public partial class PartiStudentActivProfile
    {
        public void EditPartiStudentActivCommandMapping()
        {
            CreateMap<EditParticiStudentActivCommand, ParticiStudentActivTb>();
        }
    }
}
