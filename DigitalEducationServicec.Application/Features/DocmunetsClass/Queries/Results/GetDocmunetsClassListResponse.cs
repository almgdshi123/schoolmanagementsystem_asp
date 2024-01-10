namespace DigitalEducationServicec.Application.Features.DocmunetsClass.Queries.Results
{
    public class GetDocmunetsClassListResponse
    {
        public long DocmunetsClassId { get; set; }

        public long DocmunetId { get; set; }

        public long ClassId { get; set; }

        public string DocmunetName { get; set; } = null!;

        public string? Notes { get; set; }
    }
}
