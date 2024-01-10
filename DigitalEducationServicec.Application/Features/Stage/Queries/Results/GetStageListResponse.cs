namespace DigitalEducationServicec.Application.Features.Stage.Queries.Results
{
    public class GetStageListResponse
    {
        public long StageId { get; set; }

        public string? StageName { get; set; }

        public long? SchoolId { get; set; }

        public int? NumberOfClasses { get; set; }
        public List<ClassDataTbResponse> ClassDataTbs { get; set; }
        public class ClassDataTbResponse
        {
            public long ClassId { get; set; }

            public string? ClassName { get; set; }

            public string? ClassCode { get; set; }

            public string? StageId { get; set; }
        }

    }
}
