using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellora.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        public int ReviewRating { get; set; }
        public DateTime ReviewDate { get; set; } = DateTime.Now;
        public string? ReviewDescription { get; set; }
        public int? SaleTransactionID { get; set; }
        public virtual SaleTransaction ? SaleTransaction { get; set; }
        public int? SwapTransactionID { get; set; }
        public virtual SwapTransaction ? SwapTransaction { get; set; }
        public int? ReviewerID { get; set; }
        public virtual User ? User { get; set; }
    }
}
