using System.ComponentModel.DataAnnotations;

namespace Sellora.Shared.Domain
{
    public class Staff : BaseDomainModel, IValidatableObject
    {
        [Required(ErrorMessage = "Please add staff member's first name.")]
        [StringLength(30, ErrorMessage = "First Name cannot be longer than 30 Characters.")]
        public string? StaffFirstName { get; set; }

        [Required(ErrorMessage = "Please add staff member's last name.")]
        [StringLength(30, ErrorMessage = "Last Name cannot be longer than 30 Characters.")]
        public string? StaffLastName { get; set; }

        [Required(ErrorMessage = "Please add staff member's email address.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email address.")]
        [EmailAddress]
        public string? StaffEmail { get; set; }

        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Invalid date format.")]
        public DateTime StaffHireDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Please add staff member's position.")]
        [StringLength(50, ErrorMessage = "Staff Position length is out of bounds.")]
        public string? StaffPosition { get; set; }

        [Required(ErrorMessage = "Please add staff member's address.")]
        [StringLength(100, ErrorMessage = "Address length is out of bounds.")]
        public string? StaffAddress { get; set; }

        [Required(ErrorMessage = "Please add staff member's contact number.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not a valid phone number.")]
        public string? StaffHPNum { get; set; }

        [Required(ErrorMessage = "Please add staff member's department of work.")]
        [StringLength(50, ErrorMessage = "Staff Department length is out of bounds.")]
        public string? StaffDepartment { get; set; }

        // 'Many' Side References
        public List<Report>? Reports { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Not really required due to above variable value initialisation, but leaving just in case
            if (StaffHireDate != null)
            {
                // Validates that the Staff profile creation date is not in the 'future'
                if (StaffHireDate > DateTime.Now)
                {
                    yield return new ValidationResult("Staff Date of Hire cannot be greater than Current Date", new[] { "StaffHireDate" });
                }
            }
        }
    }
}