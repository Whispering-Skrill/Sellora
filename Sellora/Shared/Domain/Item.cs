using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace Sellora.Shared.Domain
{
    public class Item : BaseDomainModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 Characters.")]
        public string? ItemName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int ItemPrice { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Condition cannot be longer than 30 Characters.")]
        public string? Condition { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ItemDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(500, ErrorMessage = "Report cannot be longer than 500 Characters.")]
        public string? ItemDescription { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Location length is out of bounds.")]
        public string? ItemLocation { get; set; }
        public string? ImageUrl { get; set; } = "https://via.placeholder.com/300";
        public int ItemLikes { get; set; }
        public int ItemClicks { get; set; }
        public int ItemStatus { get; set; }
        public int CategoryId { get; set; }
        public virtual Category ? Category { get; set; }
        public int AppUserId { get; set; }
        public virtual  AppUser ? AppUser { get; set; }
    }
}
