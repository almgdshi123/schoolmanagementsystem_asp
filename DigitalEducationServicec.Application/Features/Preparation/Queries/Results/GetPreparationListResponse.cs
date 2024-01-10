namespace DigitalEducationServicec.Application.Features.Preparation.Queries.Results
{
    public class GetPreparationListResponse
    {
        public long PreparationId { get; set; }

        public long? FileStudentId { get; set; }

        public long? DistrSubTeacherId { get; set; }

        public long? MonthAcademicId { get; set; }

        public DateTime? PreparationDate { get; set; }

        public int? Status { get; set; }

        public string? Note { get; set; }
    }
}
