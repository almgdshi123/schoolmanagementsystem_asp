using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class StudentParticipationBusTb
{
    public long StudentParticipationBusId { get; set; }

    public long? FileStudentId { get; set; }

    public long? DistributionOfBuseStreetId { get; set; }

    public string? ParticipationType { get; set; }

    public DateTime? TimeAttendance { get; set; }

    public DateTime? TimeLeave { get; set; }

    public int? Status { get; set; }

    public string? Note { get; set; }
}
