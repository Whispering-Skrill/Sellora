using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellora.Shared.Domain
{
    public class SwapTransaction : BaseDomainModel, IValidatableObject
    {
        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Invalid date format.")]
        public DateTime TransactionDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Please specify the first user.")]
        public int? AppUser1Id { get; set; }
        public virtual AppUser? AppUser1 { get; set; }

        [Required(ErrorMessage = "Please specify an item that belongs to the first user.")]
        public int? SwapItem1Id { get; set; }
        public virtual Item? SwapItem1 { get; set; }

        [Required(ErrorMessage = "Please specify the second user.")]
        public int? AppUser2Id { get; set; }
        public virtual AppUser? AppUser2 { get; set; }

        [Required(ErrorMessage = "Please specify an item that belongs to the second user.")]
        public int? SwapItem2Id { get; set; }
        public virtual Item? SwapItem2 { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Not really required due to above variable value initialisation, but leaving just in case
            if (TransactionDate != null)
            {
                // Validates that the Swap Transaction date is not in the 'future'
                if (TransactionDate > DateTime.Now)
                {
                    yield return new ValidationResult("Transaction Date cannot be greater than Current Date", new[] { "TransactionDate" });
                }
            }

            // Validates that the Users are not the same
            if (AppUser1Id == AppUser2Id)
            {
                yield return new ValidationResult("Users cannot be the same.", new[] { "AppUser1Id", "AppUser2Id" });
            }
        }
    }
}
