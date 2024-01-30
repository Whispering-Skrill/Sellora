using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellora.Shared.Domain
{
    public class Category : BaseDomainModel
    {
        [Required]
        public string? CategoryName { get; set; }

        // This is the opposite side of the relationship to the Item entity
        public virtual List<Item> ? Items { get; set; }
    }
}
