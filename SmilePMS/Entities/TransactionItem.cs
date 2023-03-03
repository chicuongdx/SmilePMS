using System;
using System.Collections.Generic;

namespace SmilePMS.Entities
{
    public partial class TransactionItem
    {
        public string Icode { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int? Qty { get; set; }
    }
}
