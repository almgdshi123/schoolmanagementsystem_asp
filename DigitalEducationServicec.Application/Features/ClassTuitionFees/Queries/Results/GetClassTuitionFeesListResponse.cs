namespace DigitalEducationServicec.Application.Features.ClassTuitionFees.Queries.Results
{
    public class GetClassTuitionFeesListResponse
    {
        public long ClassTuitionFeesId { get; set; }

        public string? ClassTuitionFeesName { get; set; }

        public string? ClassTuitionFeesType { get; set; }

        public long? TypesTuitionFeesId { get; set; }
        public string? TypesTuitionFeesName { get; set; }

        public bool? MonthlyService { get; set; }

        public bool? Installments { get; set; }

        public decimal? Amount { get; set; }

        public long? ClassId { get; set; }

        public string? ClassName { get; set; }

        public string? ClassCode { get; set; }



        public string? YearId { get; set; }
        public string? YearName { get; set; }




    }
}
