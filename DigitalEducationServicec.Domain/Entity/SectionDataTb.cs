using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class SectionDataTb
{
    public long SectionId { get; set; }

    public string? SectionName { get; set; }

    public string? SectionCode { get; set; }

    public long? ClassId { get; set; }

    public int? MaximumNumberOfStudents { get; set; }

    public int? MinimumNumberOfStudents { get; set; }

    public long? SectionCodeId { get; set; }

    public virtual ClassDataTb? Class { get; set; }

    public virtual ICollection<FileStudentTb> FileStudentTbs { get; set; } = new List<FileStudentTb>();

    public virtual SectionCodeTb? SectionCodeNavigation { get; set; }
}
