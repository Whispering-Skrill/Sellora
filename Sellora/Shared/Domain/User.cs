﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellora.Shared.Domain
{
    public class User : BaseDomainModel
    {
        public string? UserName { get; set; }
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPassword { get; set; }
        public string? UserHPNum { get; set; }
        public DateTime UserRegDate { get; set; }
        public string? UserDescription { get; set; }
        public DateTime UserLastOnline { get; set; }


        // 'Many' Side References
        public virtual List<Item> ? Items { get; set; }
        public virtual List<Report> ? Reports { get; set; }
        public virtual List<Review> ? Reviews { get; set; }
    }
}
