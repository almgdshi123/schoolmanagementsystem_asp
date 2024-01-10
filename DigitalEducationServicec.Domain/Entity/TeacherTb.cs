using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class TeacherTb
{
    public long TeacherId { get; set; }

    public string? TeacherName { get; set; }

    public string? Address { get; set; }

    public int? SpecializationId { get; set; }

    public int? QualificationId { get; set; }

    public long? UserId { get; set; }

    public string? Gender { get; set; }

    public virtual ICollection<DistributionSubTeacherTb> DistributionSubTeacherTbs { get; set; } = new List<DistributionSubTeacherTb>();

    public virtual QualificationTb? Qualification { get; set; }

    public virtual SpecializationTb? Specialization { get; set; }

    public virtual ICollection<StudentActivitieTb> StudentActivitieTbs { get; set; } = new List<StudentActivitieTb>();

    public virtual UserDataTb? User { get; set; }
}
