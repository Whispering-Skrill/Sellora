using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellora.Shared.Domain
{
    public class SaleTransaction : BaseDomainModel
    {
        public DateTime TransactionDate { get; set; }
        public string? TransactionType { get; set; }
        public int? SaleUserId { get; set; }
        public virtual User ? User { get; set; }
        public int? SaleItemId { get; set; }
        public virtual Item ? Item { get; set; }
    }
}
