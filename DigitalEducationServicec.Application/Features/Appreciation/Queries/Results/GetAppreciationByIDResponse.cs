namespace DigitalEducationServicec.Application.Features.Appreciation.Queries.Results
{
    public class GetAppreciationByIDResponse
    {
        public long AppreciationId { get; set; }

        public string? AppreciationName { get; set; }

        public string? AppreciationNameEn { get; set; }

        public string? LowScore { get; set; }

        public string? HighScore { get; set; }
    }
}
