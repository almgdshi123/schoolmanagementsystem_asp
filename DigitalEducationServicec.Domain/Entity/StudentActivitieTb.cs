using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class StudentActivitieTb
{
    public long StudentActivitieId { get; set; }

    public string StudentActivitieName { get; set; } = null!;

    public long? TypeOfActivitieId { get; set; }

    public long? TeacherId { get; set; }

    public DateTime? StudentActivitieDateSt { get; set; }

    public DateTime? StudentActivitieDateEnd { get; set; }

    public decimal? Amount { get; set; }

    public string? Location { get; set; }

    public string? Status { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<ParticiStudentActivTb> ParticiStudentActivTbs { get; set; } = new List<ParticiStudentActivTb>();

    public virtual TeacherTb? Teacher { get; set; }

    public virtual TypeOfActivitiesTb? TypeOfActivitie { get; set; }
}
