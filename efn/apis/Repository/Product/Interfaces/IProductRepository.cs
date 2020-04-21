using product = Domain.Layer.Product;

namespace Repository
{
    public interface IProductRepository
    {
        /// <summary>
        /// The method to get the product.
        /// </summary>
        /// <param name="Id">The product id.</param>
        /// <returns></returns>
        product.Product GetProduct(short Id);

        /// <summary>
        /// The method to create product.
        /// </summary>
        /// <param name="product">The product domain object</param>
        /// <returns>Return true or false; true indicates the the creation is successful.</returns>
        bool CreateProduct(product.Product product);

        /// <summary>
        /// The method to update the product details.
        /// </summary>
        /// <param name="product">The product domain object.</param>
        /// <returns>Return true or false; true indicates the the update is successful.</returns>
        bool UpdateProduct(product.Product product);
    }
}
