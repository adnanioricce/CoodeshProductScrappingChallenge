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
        public DateTimeOffset ImportedAt { get; init; }
        public string Url { get; init; }
        public string ProductName { get; init; }
        public string Quantity { get; init; }
        public string Categories { get; init; }
        public string Packaging { get; init; }
        public string Brands { get; init; }
        public string ImageUrl { get; init; }
    }    
}
