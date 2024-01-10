using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class GradesMonthTb
{
    public long GradesMonthId { get; set; }

    public long? GradesTypeId { get; set; }

    public long? DistrSubTeacherId { get; set; }

    public long? FileStudentId { get; set; }

    public long? MonthAcademicId { get; set; }

    public decimal? GradesValue { get; set; }

    public string? GradesText { get; set; }

    public string? Note { get; set; }

    public virtual DistributionSubTeacherTb? DistrSubTeacher { get; set; }

    public virtual FileStudentTb? FileStudent { get; set; }

    public virtual GradesTb? GradesType { get; set; }

    public virtual MonthAcademicTb? MonthAcademic { get; set; }
}
