using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouncilWise
{
    internal class ReceiptItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IncludesTax { get; set; }
        public decimal TaxAmount { get; set; }
    }
}
