using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class QualificationTb
{
    public int QualificationId { get; set; }

    public string? QualificationName { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<TeacherTb> TeacherTbs { get; set; } = new List<TeacherTb>();
}
