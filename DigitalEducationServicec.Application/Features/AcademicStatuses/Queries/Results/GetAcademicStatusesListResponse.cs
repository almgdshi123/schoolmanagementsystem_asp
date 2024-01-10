namespace DigitalEducationServicec.Application.Features.AcademicStatuses.Queries.Results
{
    public class GetAcademicStatusesListResponse
    {
        public long StatusId { get; set; }

        public string? StatusName { get; set; }

        public string? Note { get; set; }
    }
}
