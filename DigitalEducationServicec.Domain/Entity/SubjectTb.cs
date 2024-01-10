using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class SubjectTb
{
    public long SubjectId { get; set; }

    public string? SubjectNameArabic { get; set; }

    public string? SubjectNameEnglish { get; set; }

    public string? SubjectType { get; set; }

    public bool? SubjectIncludedInRate { get; set; }

    public decimal? LowScore { get; set; }

    public decimal? HighScore { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<DistributionClassSubTb> DistributionClassSubTbs { get; set; } = new List<DistributionClassSubTb>();
}
