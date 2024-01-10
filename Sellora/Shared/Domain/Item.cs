using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellora.Shared.Domain
{
    public class Item : BaseDomainModel
    {
        public int ItemPrice { get; set; }
        public string? Condition { get; set; }
        public DateTime ItemDate { get; set; }
        public string? ItemDescription { get; set; }
        public string? ItemLocation { get; set; }
        public int ItemLikes { get; set; }
        public int ItemClicks { get; set; }
        public int ItemStatus { get; set; }
        public int CategoryId { get; set; }
        public virtual Category ? Category { get; set; }
        public int UserId { get; set; }
    }
}
