using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellora.Shared.Domain
{
    public class SwapTransaction : BaseDomainModel
    {
        public DateTime TransactionDate { get; set; }
        public int SwapUserId { get; set; }
        public virtual User ? User { get; set; }
        public int SwapItemId { get; set; }
        public virtual Item ? Item { get; set; }
        public int SwapUser2Id { get; set; }
        public virtual User ? User2 { get; set; }
        public int SwapItem2Id { get; set; }
        public virtual Item ? Item2 { get; set; }
    }
}
