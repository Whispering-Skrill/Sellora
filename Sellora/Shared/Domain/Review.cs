using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellora.Shared.Domain
{
    public class Review : BaseDomainModel, IValidatableObject
    {
        [Required]
        [StringLength(30, ErrorMessage = "Title cannot be longer than 30 Characters.")]
        public string? ReviewTitle { get; set; }

        [Required]
        public int ReviewRating { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReviewDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(150, ErrorMessage = "Description cannot be longer than 150 Characters.")]
        public string? ReviewDescription { get; set; }

        public int? SaleTransactionID { get; set; }
        public virtual SaleTransaction ? SaleTransaction { get; set; }

        public int? SwapTransactionID { get; set; }
        public virtual SwapTransaction ? SwapTransaction { get; set; }

        [Required]
        public int? ReviewerID { get; set; }
        public virtual AppUser? User { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Not really required due to above variable value initialisation, but leaving just in case
            if (ReviewDate != null)
            {
                if (ReviewDate > DateTime.Now)
                {
                    yield return new ValidationResult("Date of Review cannot be greater than Current Date", new[] { "StaffHireDate" });
                }
            }
        }
    }
}
