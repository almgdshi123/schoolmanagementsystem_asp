using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class UserDataTb
{
    public long UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Type { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<ParentTb> ParentTbs { get; set; } = new List<ParentTb>();

    public virtual ICollection<StudentTb> StudentTbs { get; set; } = new List<StudentTb>();

    public virtual ICollection<TeacherTb> TeacherTbs { get; set; } = new List<TeacherTb>();
}
