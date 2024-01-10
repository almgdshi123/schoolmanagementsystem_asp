namespace DigitalEducationServicec.Application.Features.GradesSemester.Queries.Results
{
    public class GetGradesSemesterListResponse
    {
        public long GradesSemesterId { get; set; }

        public long? GradesTypeId { get; set; }

        public long? DistrSubTeacherId { get; set; }

        public long? FileStudentId { get; set; }

        public long? SemesterAcademicId { get; set; }

        public decimal? GradesValue { get; set; }

        public string? GradesText { get; set; }

        public string? Note { get; set; }
    }
}
