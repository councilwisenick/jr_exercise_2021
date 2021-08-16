using System.Collections.Generic;
using System.Text;

namespace CouncilWise
{
    internal class Receipt
    {
        public ICollection<ReceiptItem> Items { get; set; }
        public decimal Total { get; set; }
        public decimal TaxTotal { get; set; }
    }
}
