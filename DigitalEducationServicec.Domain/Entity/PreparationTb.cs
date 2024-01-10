using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class PreparationTb
{
    public long PreparationId { get; set; }

    public long? FileStudentId { get; set; }

    public long? DistrSubTeacherId { get; set; }

    public long? MonthAcademicId { get; set; }

    public DateTime? PreparationDate { get; set; }

    public int? Status { get; set; }

    public string? Note { get; set; }

    public virtual DistributionSubTeacherTb? DistrSubTeacher { get; set; }

    public virtual FileStudentTb? FileStudent { get; set; }

    public virtual MonthAcademicTb? MonthAcademic { get; set; }
}
