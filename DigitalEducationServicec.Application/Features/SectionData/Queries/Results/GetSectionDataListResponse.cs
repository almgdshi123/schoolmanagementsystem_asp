namespace DigitalEducationServicec.Application.Features.SectionData.Queries.Results
{
    public class GetSectionDataListResponse
    {
        public long SectionId { get; set; }

        public string? SectionName { get; set; }

        public string? SectionCode { get; set; }

        public long? ClassId { get; set; }

        public int? MaximumNumberOfStudents { get; set; }

        public int? MinimumNumberOfStudents { get; set; }

    }
}
