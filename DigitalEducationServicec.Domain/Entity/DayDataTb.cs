using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class DayDataTb
{
    public long DayId { get; set; }

    public string? DayName { get; set; }

    public string? Notes { get; set; }
}
