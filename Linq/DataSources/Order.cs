using System;

namespace Linq.DataSources
{
    public class Order
    {
        public int OrderId { get; set; }
        
        public DateTime OrderDate { get; set; }
        
        public decimal Total { get; set; }
        
        public override string ToString() => $"{OrderId}: {OrderDate:d} for {Total:C2}";
    }
}