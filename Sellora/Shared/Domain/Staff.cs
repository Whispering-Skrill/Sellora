using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellora.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? StaffFirstName { get; set; }
        public string? StaffLastName { get; set; }
        public string? StaffEmail { get; set; }
        public DateTime StaffHireDate { get; set; } = DateTime.Now;
        public string? StaffPosition { get; set; }
        public string? StaffAddress { get; set; }
        public string? StaffHPNum { get; set; }
        public string? StaffDepartment { get; set; }


        // 'Many' Side References
        public List<Report> ? Reports { get; set; }
    }
}
