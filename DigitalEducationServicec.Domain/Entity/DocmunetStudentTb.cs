using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class DocmunetStudentTb
{
    public long DocmunetStudentId { get; set; }

    public long DocmunetsClassId { get; set; }

    public long FileStudentId { get; set; }

    public string DocmunetType { get; set; } = null!;

    public string DocmunetStatus { get; set; } = null!;

    public string? Notes { get; set; }

    public virtual DocmunetsClassTb DocmunetsClass { get; set; } = null!;

    public virtual FileStudentTb FileStudent { get; set; } = null!;
}
