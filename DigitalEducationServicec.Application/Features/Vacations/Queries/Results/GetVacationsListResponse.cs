namespace DigitalEducationServicec.Application.Features.Vacations.Queries.Results
{
    public class GetVacationsListResponse
    {
        public long VacationId { get; set; }

        public string? VacationName { get; set; }

        public DateTime? VacationDateSt { get; set; }

        public DateTime? VacationDateEnd { get; set; }

        public string? YearId { get; set; }

        public string? VacationType { get; set; }
    }
}
