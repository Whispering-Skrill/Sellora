using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellora.Shared.Domain
{
    public class Report : BaseDomainModel
    {
        public string? ReportContent { get; set; }
        public DateTime ReportDate { get; set; }
        public int ReporterID { get; set; }
        public virtual required User User { get; set; }
        public int StaffID { get; set; }
        public virtual Staff ? Staff { get; set; }
        public int SaleTransactionID { get; set; }
        public virtual SaleTransaction ? SaleTransaction { get; set; }
        public int SwapTransactionID { get; set; }
        public virtual SwapTransaction ? SwapTransaction { get; set;}
    }
}
