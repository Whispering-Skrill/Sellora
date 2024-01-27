using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace Sellora.Shared.Domain
{
    public class Item : BaseDomainModel
    {
        public string? ItemName { get; set; }
        public int ItemPrice { get; set; }
        public string? Condition { get; set; }
        public DateTime ItemDate { get; set; } = DateTime.Now;
        public string? ItemDescription { get; set; }
        public string? ItemLocation { get; set; }
        public string? ImageUrl { get; set; }
        public int ItemLikes { get; set; }
        public int ItemClicks { get; set; }
        public int ItemStatus { get; set; }
        public int CategoryId { get; set; }
        public virtual Category ? Category { get; set; }
        public int AppUserId { get; set; }
        public virtual  AppUser ? AppUser { get; set; }
    }
}
