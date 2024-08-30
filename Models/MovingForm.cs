using System.ComponentModel.DataAnnotations;

namespace royaltjänstflytt.Models
{
    public class Move
    {
        public Guid Id { get; set; }
        // Required field with validation
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }

        public string SocialSecurityNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? Date { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan? StartTime { get; set; }

        public string StreetAddress { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int? SquareMeters { get; set; }

        public string Residence { get; set; }
        public string Apartment { get; set; }

        [DataType(DataType.MultilineText)]
        public string AdditionalInformation { get; set; }
        public string? FileUrl { get; set; }
    }  
}
