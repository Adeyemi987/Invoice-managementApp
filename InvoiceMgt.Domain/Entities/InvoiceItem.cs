using InvoiceMgt.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceMgt.Domain.Entities
{
    public class InvoiceItem : AuditEntity
    {
        public int Id{ get; set; }

        public int InvoiceId { get; set; }
        public string Item { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public Invoice Invoice { get; set; }


    }
}
