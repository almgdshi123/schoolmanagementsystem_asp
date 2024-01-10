namespace DigitalEducationServicec.Application.Features.DocmunetStudent.Queries.Results
{
    public class GetDocmunetStudentListResponse
    {
        public long DocmunetStudentId { get; set; }

        public long DocmunetsClassId { get; set; }

        public long FileStudentId { get; set; }

        public string DocmunetType { get; set; } = null!;

        public string DocmunetStatus { get; set; } = null!;

        public string? Notes { get; set; }


    }
}
