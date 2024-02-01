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
        [Required(ErrorMessage = "Report Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 Characters.")]
        public string ReportTitle { get; set; }

        [Required(ErrorMessage = "Report Content is required.")]
        [StringLength(1000, ErrorMessage = "Report cannot be longer than 1000 Characters.")]
        public string ReportContent { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReportDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Please specify the creator of this report.")]
        public int? AppUserID { get; set; }
        public virtual AppUser? AppUser { get; set; }

        [Required(ErrorMessage = "Please assign a member of staff to handle this report.")]
        public int? StaffID { get; set; } = 1;
        public virtual Staff ? Staff { get; set; }

        public int? SaleTransactionID { get; set; }
        public virtual SaleTransaction ? SaleTransaction { get; set; }

        public int? SwapTransactionID { get; set; }
        public virtual SwapTransaction ? SwapTransaction { get; set;}

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (AppUserID == null)
            {
                yield return new ValidationResult("Please specify the creator of this report.", new[] { "AppUserID" });
            }
            // Validates that the Report creation date is not in the 'future'
            if (ReportDate > DateTime.Now)
            {
                yield return new ValidationResult("Date of Report cannot be greater than Current Date", new[] { "ReportDate" });
            }

            // Validates the Transaction Chosen
            if ((SaleTransactionID == null && SwapTransactionID == null) || (SaleTransactionID != null && SwapTransactionID != null))
            {
                yield return new ValidationResult("Please specify only one transaction (either Sale Transaction or Swap Transaction).", new[] { "SaleTransactionID", "SwapTransactionID" });
            }
        }
    }
}
