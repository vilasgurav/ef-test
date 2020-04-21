using Domain.Layer;
using Repository;
using product = Domain.Layer.Product;

namespace Orchastrator.Product
{
    public class ProductOrc : IProductOrc
    {
        IProductRepository productRep;

        /// <summary>
        /// The method to get the product.
        /// </summary>
        /// <param name="Id">The product id.</param>
        /// <returns></returns>
        public product.Product GetProduct(short id)
        {
            productRep = new ProductRepository();
            return productRep.GetProduct(id);
        }

        /// <summary>
        /// The method to create product.
        /// </summary>
        /// <param name="product">The product domain object</param>
        /// <returns>Return true or false; true indicates the the creation is successful.</returns>
        public bool CreateProduct(product.Product product)
        {
            productRep = new ProductRepository();
            CurrentGoldPricePerGram.Instance.currentGoldPricePerGram = product.PricePerGram;
            return productRep.CreateProduct(product);
        }

        /// <summary>
        /// The method to update the product details.
        /// </summary>
        /// <param name="product">The product domain object.</param>
        /// <returns>Return true or false; true indicates the the update is successful.</returns>
        public bool UpdateProduct(product.Product product)
        {
            productRep = new ProductRepository();
            return productRep.UpdateProduct(product);
        }
    }
}
