using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class DistributionClassSubTb
{
    public long DistrClassSubId { get; set; }

    public long ClassId { get; set; }

    public string? ClassCode { get; set; }

    public long? SubjectId { get; set; }

    public string? Note { get; set; }

    public virtual ClassDataTb Class { get; set; } = null!;

    public virtual ICollection<DistributionSubTeacherTb> DistributionSubTeacherTbs { get; set; } = new List<DistributionSubTeacherTb>();

    public virtual SubjectTb? Subject { get; set; }
}
