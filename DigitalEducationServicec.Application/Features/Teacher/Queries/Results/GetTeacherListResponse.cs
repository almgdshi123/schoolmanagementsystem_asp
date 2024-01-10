namespace DigitalEducationServicec.Application.Features.Teacher.Queries.Results
{
    public class GetTeacherListResponse
    {
        public long TeacherId { get; set; }

        public string? TeacherName { get; set; }

        public string? Address { get; set; }

        public int? SpecializationId { get; set; }

        public int? QualificationId { get; set; }

        public long? UserId { get; set; }

        public string? Gender { get; set; }
    }
}
