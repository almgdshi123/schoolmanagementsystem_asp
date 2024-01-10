﻿using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Appreciation.Commands.Models
{
    public class EditAppreciationCommand : IRequest<Response<string>>
    {
        public long AppreciationId { get; set; }

        public string? AppreciationName { get; set; }

        public string? AppreciationNameEn { get; set; }

        public string? LowScore { get; set; }

        public string? HighScore { get; set; }
    }
}
