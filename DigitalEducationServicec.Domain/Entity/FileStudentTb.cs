using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class FileStudentTb
{
    public long FileStudentId { get; set; }

    public long? StudentId { get; set; }

    public long? FinancialNumber { get; set; }

    public string? YearId { get; set; }

    public DateTime? RenewalDate { get; set; }

    public long? SectionId { get; set; }

    public long? StatusId { get; set; }

    public long? SystemId { get; set; }

    public int? Status { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<DocmunetStudentTb> DocmunetStudentTbs { get; set; } = new List<DocmunetStudentTb>();

    public virtual ICollection<GradesMonthTb> GradesMonthTbs { get; set; } = new List<GradesMonthTb>();

    public virtual ICollection<GradesSemesterTb> GradesSemesterTbs { get; set; } = new List<GradesSemesterTb>();

    public virtual ICollection<ParticiStudentActivTb> ParticiStudentActivTbs { get; set; } = new List<ParticiStudentActivTb>();

    public virtual ICollection<PreparationTb> PreparationTbs { get; set; } = new List<PreparationTb>();

    public virtual SectionDataTb? Section { get; set; }

    public virtual StudentTb? StatusNavigation { get; set; }

    public virtual ICollection<SubmittedHomeworkTb> SubmittedHomeworkTbs { get; set; } = new List<SubmittedHomeworkTb>();

    public virtual YearDataTb? Year { get; set; }
}
