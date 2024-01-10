using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class StageTb
{
    public long StageId { get; set; }

    public string? StageName { get; set; }

    public long? SchoolId { get; set; }

    public int? NumberOfClasses { get; set; }

    public virtual ICollection<ClassDataTb> ClassDataTbs { get; set; } = new List<ClassDataTb>();
}
