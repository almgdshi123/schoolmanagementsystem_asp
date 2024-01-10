using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class AcademicStatusesTb
{
    public long StatusId { get; set; }

    public string? StatusName { get; set; }

    public string? Note { get; set; }
}
