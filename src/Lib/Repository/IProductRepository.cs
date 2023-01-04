using ProductScrapper;

namespace Lib.Repository
{
    //TODO: If needed, create a generic class. This didn't seemed necessary to me.
    public interface IProductRepository
    {
        /// <summary>
        /// Inserts given <paramref name="product"/> on database
        /// </summary>
        /// <param name="product">the product to be inserted</param>
        /// <returns>A Task with it's state</returns>
        Task Create(Product product);
        /// <summary>
        /// Get a product by it's Id. this is not the Code of the product.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A <see cref="Task"/> with the retrieved product as <see cref="Product"/></returns>
        Task<Product> GetByIdAsync(long id);

        Task<Product> GetByCodeAsync(long code);
        /// <summary>
        /// List products from the database
        /// </summary>
        /// <returns>a list of products as a <see cref="IEnumerable{T}"/> of <see cref="Product"/></returns>
        Task<IEnumerable<Product>> ListAsync();
        /// <summary>
        /// List products from the database with pagination
        /// </summary>
        /// <param name="page">Where to start</param>
        /// <param name="pageCount">The number of elements to retrieve</param>
        /// <returns>a <see cref="IEnumerable{T}"/> of <see cref="Product"/></returns>
        Task<IEnumerable<Product>> ListAsync(int page, int pageCount);
        /// <summary>
        /// Iteratively tries to save each product in given <paramref name="products"/> param
        /// </summary>
        /// <param name="products">the products to be saved</param>
        /// <returns>a <see cref="Task"/> with the task state</returns>
        Task BulkCreateAsync(IEnumerable<Product> products);
    }
}