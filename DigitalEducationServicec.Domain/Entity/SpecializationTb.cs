using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class SpecializationTb
{
    public int SpecializationId { get; set; }

    public string? SpecializationName { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<TeacherTb> TeacherTbs { get; set; } = new List<TeacherTb>();
}
