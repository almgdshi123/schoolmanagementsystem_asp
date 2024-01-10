namespace DigitalEducationServicec.Application.Features.DistributionClassSub.Queries.Results
{
    public class GetDistributionClassSubListResponse
    {
        public long DistrClassSubId { get; set; }

        public long ClassId { get; set; }
        public string? ClassName { get; set; }

        public string? ClassCode { get; set; }



        public long? SubjectId { get; set; }

        public string? SubjectNameArabic { get; set; }

        public string? SubjectNameEnglish { get; set; }

        public string? SubjectType { get; set; }


        public string? Note { get; set; }

    }
}
