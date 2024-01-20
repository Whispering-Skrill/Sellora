using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellora.Shared.Domain
{
    public class Report : BaseDomainModel, IValidatableObject
    {
        [Required]
        [StringLength(30, ErrorMessage = "Title cannot be longer than 30 Characters.")]
        public string? ReportTitle { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Report cannot be longer than 500 Characters.")]
        public string? ReportContent { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReportDate { get; set; } = DateTime.Now;

        // FOR TESTING
        [Required]
        public int AppUserID { get; set; }
        public virtual AppUser ? AppUser { get; set; }

        public int StaffID { get; set; }
        public virtual Staff ? Staff { get; set; }

        public int? SaleTransactionID { get; set; }
        public virtual SaleTransaction ? SaleTransaction { get; set; }

        public int? SwapTransactionID { get; set; }
        public virtual SwapTransaction ? SwapTransaction { get; set;}

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Not really required due to above variable value initialisation, but leaving just in case
            if (ReportDate != null)
            {
                if (ReportDate > DateTime.Now)
                {
                    yield return new ValidationResult("Date of Report cannot be greater than Current Date", new[] { "ReportDate" });
                }
            }
        }
    }
}
