using System.Data;

namespace ProductScrapper
{
    public enum ProductStatus
    {
        Draft,Imported
    }
    public record struct Product
    {
        public long Id { get; init; }
        public long Code { get; init; }
        public string Barcode { get; init; }
        public ProductStatus Status { get; init; }
        public string ImportedAt { get; init; }
        public string Url { get; init; }
        public string ProductName { get; init; }
        public string Quantity { get; init; }
        public string Categories { get; init; }
        public string Packaging { get; init; }
        public string Brands { get; init; }
        public string ImageUrl { get; init; }
        public static Product Read(IDataReader reader)
        {
            return new Product()
            {
                Id = Convert.ToInt64(reader["Id"]?.ToString() ?? ""),
                Code = Convert.ToInt64(reader["Code"]?.ToString() ?? ""),
                Barcode = reader["Barcode"]?.ToString() ?? "",                
                Status = Enum.Parse<ProductStatus>(reader["Status"]?.ToString() ?? ""),
                ImportedAt = reader["ImportedAt"]?.ToString() ?? "",
                Url = reader["Url"]?.ToString() ?? "",
                ProductName = reader["ProductName"]?.ToString() ?? "",
                Quantity = reader["Quantity"]?.ToString() ?? "",
                Categories = reader["Categories"]?.ToString() ?? "",
                Packaging = reader["Packaging"]?.ToString() ?? "",
                Brands = reader["Brands"]?.ToString() ?? "",
                ImageUrl = reader["ImageUrl"]?.ToString() ?? ""
            };
        }
    }            
}
