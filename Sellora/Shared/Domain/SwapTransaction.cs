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
        public int UserId { get; set; }
        public int User2Id { get; set; }

        public int ItemId { get; set; }
        public virtual Item ? Item { get; set; }
        public int Item2Id { get; set; }
        public virtual Item ? Item2 { get; set; }
    }
}
