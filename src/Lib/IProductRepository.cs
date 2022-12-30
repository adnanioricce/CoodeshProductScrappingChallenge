namespace ProductScrapper
{
    //TODO: If needed, create a generic class. This didn't seemed necessary to me.
    public interface IProductRepository
    {
        /// <summary>
        /// Inserts given <paramref name="product"/> on database
        /// </summary>
        /// <param name="product">the product to be inserted</param>
        /// <returns>A Task with it's state</returns>
        Task Create(ProductDto product);
        /// <summary>
        /// Get a product by it's Id. this is not the Code of the product.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A <see cref="Task"/> with the retrieved product as <see cref="ProductDto"/></returns>
        Task<ProductDto> GetByIdAsync(long id);

        Task<ProductDto> GetByCodeAsync(long code);
        /// <summary>
        /// List products from the database
        /// </summary>
        /// <returns>a list of products as a <see cref="IEnumerable{T}"/> of <see cref="ProductDto"/></returns>
        Task<IEnumerable<ProductDto>> ListAsync();
        Task BulkCreateAsync(IEnumerable<ProductDto> products);
        Task UpdateRemainingFields(ProductDto product);
    }
}