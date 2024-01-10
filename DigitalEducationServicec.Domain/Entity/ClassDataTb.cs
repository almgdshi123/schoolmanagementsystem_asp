using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class ClassDataTb
{
    public long ClassId { get; set; }

    public string? ClassName { get; set; }

    public string? ClassCode { get; set; }

    public long? StageId { get; set; }

    public int? NumberOfSections { get; set; }

    public virtual ICollection<ClassTuitionFeesTb> ClassTuitionFeesTbs { get; set; } = new List<ClassTuitionFeesTb>();

    public virtual ICollection<DistributionClassSubTb> DistributionClassSubTbs { get; set; } = new List<DistributionClassSubTb>();

    public virtual ICollection<DocmunetsClassTb> DocmunetsClassTbs { get; set; } = new List<DocmunetsClassTb>();

    public virtual ICollection<SectionDataTb> SectionDataTbs { get; set; } = new List<SectionDataTb>();

    public virtual StageTb? Stage { get; set; }
}
