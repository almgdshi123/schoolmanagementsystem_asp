using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class StudentsParentRelTb
{
    public long ParentId { get; set; }

    public long StudentId { get; set; }

    public string? Relationship { get; set; }

    public virtual ParentTb Parent { get; set; } = null!;

    public virtual StudentTb Student { get; set; } = null!;
}
