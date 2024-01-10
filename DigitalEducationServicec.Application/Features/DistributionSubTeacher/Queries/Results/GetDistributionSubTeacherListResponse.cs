namespace DigitalEducationServicec.Application.Features.DistributionSubTeacher.Queries.Results
{
    public class GetDistributionSubTeacherListResponse
    {
        public long DistrSubTeacherId { get; set; }

        public long DistrClassSubId { get; set; }

        public long TeacherId { get; set; }

        public long SemesterAcademicId { get; set; }

        public DateTime? DistrDate { get; set; }

        public int? Status { get; set; }

        public string? Note { get; set; }
    }
}
