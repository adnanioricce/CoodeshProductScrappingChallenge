using System.Data;

namespace ProductScrapper
{
    public enum ProductStatus
    {
        Draft,Imported
    }
    public record struct ProductDto
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
        public static ProductDto Read(IDataReader reader)
        {
            return new ProductDto()
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
    public record struct ProductQuantity(decimal Amount,string Metric)
    {
        public static ProductQuantity Create(string quantity)
        {
            var quantityAmountStr = new String(quantity.Where((ch) => Char.IsDigit(ch) || ch == '.' || ch == ',').ToArray());
            var quantityMetric = new String(quantity.Where((ch) => !Char.IsDigit(ch) && ch != '.' && ch != ',').ToArray());
            var quantityAmount = decimal.TryParse(quantityAmountStr, out var quantityAmountDec) ? quantityAmountDec : 0.0m;
            return new ProductQuantity(quantityAmount, quantityMetric);            
        }
    }
    public readonly record struct Product
    {
        public long Id { get; init; } = default!;
        public long Code { get; init; } = default!;
        public string Barcode { get; init; } = default!;
        public ProductStatus Status { get; init; } = ProductStatus.Draft;
        public DateTimeOffset ImportedAt { get; init; }
        public Uri Url { get; init; } = new Uri("");
        public string ProductName { get; init; } = default!;
        public ProductQuantity Quantity { get; init; } = default!;
        public string[] Categories { get; init; } = default!;
        public string[] Packaging { get; init; } = default!;
        public string[] Brands { get; init; } = default!;
        public string ImageUrl { get; init; } = default!;
        public Product()
        {

        }        
        public static Product From(ProductDto dto)
        {
            var id = dto.Id;
            var code = dto.Code;
            var barcode = dto.Barcode;
            var status = dto.Status;
            var importedAt = DateTimeOffset.TryParse(dto.ImportedAt,out var importedAtDate) ? importedAtDate : DateTimeOffset.UtcNow;
            var url = Uri.TryCreate(dto.Url,UriKind.Absolute,out var resultUrl) ? resultUrl : new Uri("");
            var quantity = ProductQuantity.Create(dto.Quantity);
            var categories = dto.Categories.Split(",");
            var packaging = dto.Packaging.Split(",");
            var brands = dto.Brands.Split(",");
            var imageUrl = dto.ImageUrl;
            return new Product()
            {
                Id = id
                ,Code = code
                ,Barcode = barcode
                ,Status = status
                ,ImportedAt = importedAt
                ,Url = url
                ,Quantity = quantity
                ,Categories = categories
                ,Packaging = packaging
                ,Brands = brands
                ,ImageUrl = imageUrl
            };
        }
    }
}
