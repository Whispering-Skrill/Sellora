using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellora.Shared.Domain
{
    public class AppUser : BaseDomainModel
    {
        public string? UserName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "First Name cannot be longer than 30 Characters.")]
        public string? UserFirstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Last Name cannot be longer than 30 Characters.")]
        public string? UserLastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string? UserEmail { get; set; }
        public string? UserPassword { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not a valid phone number.")]
        public string? UserHPNum { get; set; }
        public DateTime UserRegDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(500, ErrorMessage = "Cannot be longer than 500 Characters.")]
        public string? UserDescription { get; set; }
        public DateTime UserLastOnline { get; set; } = DateTime.Now;


        // 'Many' Side References
        public virtual List<Item> ? Items { get; set; }
        public virtual List<Report> ? Reports { get; set; }
        public virtual List<Review> ? Reviews { get; set; }
        public virtual List<SaleTransaction>? SaleTransactions { get; set; }
    }
}
