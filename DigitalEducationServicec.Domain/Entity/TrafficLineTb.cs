using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class TrafficLineTb
{
    public long TrafficLineId { get; set; }

    public string? TrafficLineName { get; set; }

    public string? Description { get; set; }
}
