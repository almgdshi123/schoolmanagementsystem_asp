using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class SchoolGroupTb
{
    public long SchoolGroupId { get; set; }

    public string? SchoolGroupName { get; set; }

    public int? NumberOfSchools { get; set; }

    public virtual ICollection<SchoolTb> SchoolTbs { get; set; } = new List<SchoolTb>();
}
