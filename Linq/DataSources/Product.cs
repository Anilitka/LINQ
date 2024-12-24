using System;

namespace Linq.DataSources
{
#pragma warning disable S3897 // Classes that provide "Equals(<T>)" should implement "IEquatable<T>"
#pragma warning disable S4035 // Classes implementing "IEquatable<T>" should be sealed
    public class Product
#pragma warning restore S4035 // Classes implementing "IEquatable<T>" should be sealed
#pragma warning restore S3897 // Classes that provide "Equals(<T>)" should implement "IEquatable<T>"
    {
        public int ProductId { get; set; }
        
        public string ProductName { get; set; }
        
        public string Category { get; set; }
        
        public decimal UnitPrice { get; set; }
        
        public int UnitsInStock { get; set; }
        
        public override string ToString() =>
            $"ProductId={ProductId} ProductName={ProductName} Category={Category} UnitPrice={UnitPrice:C2} UnitsInStock={UnitsInStock}";
            
        public bool Equals(Product other)
        {
            return ProductId == other.ProductId && ProductName == other.ProductName && Category == other.Category && UnitPrice == other.UnitPrice && UnitsInStock == other.UnitsInStock;
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Product) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ProductId, ProductName, Category, UnitPrice, UnitsInStock);
        }
    }
}