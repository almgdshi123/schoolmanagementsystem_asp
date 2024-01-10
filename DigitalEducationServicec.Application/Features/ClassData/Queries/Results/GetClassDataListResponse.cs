namespace DigitalEducationServicec.Application.Features.ClassData.Queries.Results
{
    public class GetClassDataListResponse
    {
        public long ClassId { get; set; }

        public string? ClassName { get; set; }

        public string? ClassCode { get; set; }
        public long? StageId { get; set; }

        public string? StageName { get; set; }
    }
}
