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
        [DataType(DataType.DateTime)]
        public DateTime TransactionDate { get; set; } = DateTime.Now;

        [Required]
        public int? AppUser1Id { get; set; }
        public virtual AppUser? User1 { get; set; }

        [Required]
        public int? SwapItem1Id { get; set; }
        public virtual Item ? Item1 { get; set; }

        [Required]
        public int? AppUser2Id { get; set; }
        public virtual AppUser? User2 { get; set; }

        [Required]
        public int? SwapItem2Id { get; set; }
        public virtual Item ? Item2 { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Not really required due to above variable value initialisation, but leaving just in case
            if (TransactionDate != null)
            {
                if (TransactionDate > DateTime.Now)
                {
                    yield return new ValidationResult("Transaction Date cannot be greater than Current Date", new[] { "TransactionDate" });
                }
            }
        }
    }
}
