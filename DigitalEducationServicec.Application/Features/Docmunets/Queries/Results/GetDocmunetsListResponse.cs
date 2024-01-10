namespace DigitalEducationServicec.Application.Features.Docmunets.Queries.Results
{
    public class GetDocmunetsListResponse
    {
        public long DocmunetId { get; set; }

        public string DocmunetName { get; set; } = null!;

        public string? Notes { get; set; }

    }
}
