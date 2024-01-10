using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class AcademicSystemsTb
{
    public long SystemId { get; set; }

    public string? SystemName { get; set; }

    public string? Note { get; set; }
}
