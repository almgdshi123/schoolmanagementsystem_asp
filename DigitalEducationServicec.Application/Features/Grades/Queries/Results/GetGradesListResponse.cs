namespace DigitalEducationServicec.Application.Features.Grades.Queries.Results
{
    public class GetGradesListResponse
    {
        public long GradesTypeId { get; set; }

        public string? GradesName { get; set; }

        public string? GradesType { get; set; }

        public string? Note { get; set; }
    }
}
