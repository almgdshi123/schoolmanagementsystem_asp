using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class SemesterTb
{
    public long SemesterId { get; set; }

    public string? SemesterName { get; set; }

    public string? SemesterType { get; set; }

    public virtual ICollection<SemesterAcademicTb> SemesterAcademicTbs { get; set; } = new List<SemesterAcademicTb>();
}
