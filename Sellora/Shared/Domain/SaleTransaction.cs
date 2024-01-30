using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellora.Shared.Domain
{
    public class SaleTransaction : BaseDomainModel
    {
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public int? AppUserId { get; set; }
        public virtual AppUser? AppUser { get; set; }
        public int? ItemId { get; set; }
        public virtual Item ? Item { get; set; }
    }
}
