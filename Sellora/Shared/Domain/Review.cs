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
        [Required(ErrorMessage = "Please add a review title.")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 Characters.")]
        public string? ReviewTitle { get; set; }

        [Required(ErrorMessage = "Please leave a rating.")]
        [Range(0, 5, ErrorMessage = "Rating must be a number from 0 to 5.")]
        public int ReviewRating { get; set; }

        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Invalid date format.")]
        public DateTime ReviewDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Please describe your experience.")]
        [StringLength(1000, ErrorMessage = "Description cannot be longer than 1000 Characters.")]
        public string? ReviewDescription { get; set; }

        public int? SaleTransactionID { get; set; }
        public virtual SaleTransaction ? SaleTransaction { get; set; }

        public int? SwapTransactionID { get; set; }
        public virtual SwapTransaction ? SwapTransaction { get; set; }

        [Required(ErrorMessage = "Please specify the creator of this review.")]
        public int? AppUserID { get; set; }
        public virtual AppUser? AppUser { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Not really required due to above variable value initialisation, but leaving just in case
            if (ReviewDate != null)
            {
                // Validates that the Review creation date is not in the 'future'
                if (ReviewDate > DateTime.Now)
                {
                    yield return new ValidationResult("Date of Review cannot be greater than Current Date", new[] { "ReviewDate" });
                }
            }

            // Validates the Review Rating range
            if (ReviewRating > 5 || ReviewRating < 0)
            {
                yield return new ValidationResult("Rating must be a number ranging from 0 to 5", new[] { "ReviewRating " });
            }

            // Validates the Transaction Chosen
            if ((SaleTransactionID == null && SwapTransactionID == null) || (SaleTransactionID != null && SwapTransactionID != null))
            {
                yield return new ValidationResult("Please specify only one transaction (either Sale Transaction or Swap Transaction).", new[] { "SaleTransactionID", "SwapTransactionID" });
            }
        }
    }
}
