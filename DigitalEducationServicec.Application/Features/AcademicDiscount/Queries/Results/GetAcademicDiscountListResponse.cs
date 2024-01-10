namespace DigitalEducationServicec.Application.Features.AcademicDiscount.Queries.Results
{
    public class GetAcademicDiscountListResponse
    {
        public long AcademicDiscountId { get; set; }

        public string? AcademicDiscountName { get; set; }

        public string? AcademicDiscountType { get; set; }

        public decimal? AmountDiscount { get; set; }

        public long? TypesDiscountId { get; set; }
        public string? TypesDiscountName { get; set; }


        public string? YearId { get; set; }
        public string? YearName { get; set; }


    }
}
