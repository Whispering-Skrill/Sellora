using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellora.Shared.Domain
{
    public class SaleTransaction : BaseDomainModel
    {
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public string? TransactionType { get; set; }
        public int? AppUserId { get; set; }
        public virtual AppUser? AppUser { get; set; }
        public int? ItemId { get; set; }
        public virtual Item ? Item { get; set; }
    }
}
