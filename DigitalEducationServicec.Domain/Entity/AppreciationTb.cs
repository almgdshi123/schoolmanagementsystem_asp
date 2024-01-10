using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class AppreciationTb
{
    public long AppreciationId { get; set; }

    public string? AppreciationName { get; set; }

    public string? AppreciationNameEn { get; set; }

    public string? LowScore { get; set; }

    public string? HighScore { get; set; }
}
