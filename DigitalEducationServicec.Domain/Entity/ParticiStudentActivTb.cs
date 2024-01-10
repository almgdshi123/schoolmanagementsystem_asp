using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class ParticiStudentActivTb
{
    public long ParticiStudentActivId { get; set; }

    public long StudentActivitieId { get; set; }

    public long FileStudentId { get; set; }

    public string DocmunetStatus { get; set; } = null!;

    public string? Notes { get; set; }

    public virtual FileStudentTb FileStudent { get; set; } = null!;

    public virtual StudentActivitieTb StudentActivitie { get; set; } = null!;
}
