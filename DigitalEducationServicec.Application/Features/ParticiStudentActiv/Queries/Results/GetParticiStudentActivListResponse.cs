namespace DigitalEducationServicec.Application.Features.ParticiStudentActiv.Queries.Results
{
    public class GetParticiStudentActivListResponse
    {
        public long ParticiStudentActivId { get; set; }

        public long StudentActivitieId { get; set; }

        public long FileStudentId { get; set; }

        public string DocmunetStatus { get; set; } = null!;

        public string? Notes { get; set; }
    }
}
