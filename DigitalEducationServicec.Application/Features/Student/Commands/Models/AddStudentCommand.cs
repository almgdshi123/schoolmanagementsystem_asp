using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Student.Commands.Models
{
    public class AddStudentCommand : IRequest<Response<string>>
    {

        public string? FirstName { get; set; }

        public string? SecondName { get; set; }

        public string? ThirdName { get; set; }

        public string? FourthName { get; set; }

        public string? LastName { get; set; }

        public string? FullNameArabic { get; set; }

        public string? FullNameEnglish { get; set; }

        public string? Gender { get; set; }

        public string? Nationality { get; set; }

        public string? Religion { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? BirthPlace { get; set; }

        public string? Country { get; set; }

        public string? Province { get; set; }

        public string? District { get; set; }

        public DateTime? EnrollmentDate { get; set; }

        public string? PhoneNumber { get; set; }

        public string? MobileNumber { get; set; }

        public string? ResidenceProvince { get; set; }

        public string? ResidenceDistrict { get; set; }

        public string? ResidenceStreet { get; set; }

        public string? Address { get; set; }

        public string? BusLine { get; set; }

        public string? StudentPhoto { get; set; }

        public string? Note { get; set; }


    }
}
