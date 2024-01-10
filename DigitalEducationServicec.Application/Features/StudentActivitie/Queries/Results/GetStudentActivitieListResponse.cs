namespace DigitalEducationServicec.Application.Features.StudentActivitie.Queries.Results
{
    public class GetStudentActivitieListResponse
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

    }
}
