using System;
using product = Domain.Layer.Product;
using System.Linq;

namespace Repository
{

    /// <summary>
    /// The repository to process product operations.
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        efn_testEntities3 dbContext = new efn_testEntities3();
        /// <summary>
        /// The method to get the product.
        /// </summary>
        /// <param name="Id">The product id.</param>
        /// <returns></returns>
        public product.Product GetProduct(short Id)
        {
            var data = dbContext.Products
                                  .Where(s => s.Id == Id)
                                  .FirstOrDefault();
            return data != null ? MapRepToDomainProduct(data) : null;
        }


        /// <summary>
        /// The method to create product.
        /// </summary>
        /// <param name="product">The product domain object</param>
        /// <returns>Return true or false; true indicates the the creation is successful.</returns>
        public bool CreateProduct(product.Product product)
        {
            dbContext.Products.Add(MapProduct(product));
            var result = dbContext.SaveChanges();
            return result > 0 ? true : false;
        }


        /// <summary>
        /// The method to update the product details.
        /// </summary>
        /// <param name="product">The product domain object.</param>
        /// <returns>Return true or false; true indicates the the update is successful.</returns>
        public bool UpdateProduct(product.Product product)
        {
            var productToUpdate = dbContext.Products
                                  .Where(s => s.Id == product.Id)
                                  .FirstOrDefault();

            productToUpdate.Name = product.Name;
            productToUpdate.UpdateDate = product.UpdateDate;
            productToUpdate.PricePerGram = product.PricePerGram;
            dbContext.Products.Add(productToUpdate);
            var result = dbContext.SaveChanges();
            return result > 0 ? true : false;
        }

        #region private methods
        private product.Product MapRepToDomainProduct(Product product)
        {
            return new product.Product()
            {
                Id = (short)product.Id,
                CreateDate = product.CreateDate,
                Name = product.Name,
                PricePerGram = product.PricePerGram,
                UpdateDate = product.UpdateDate
            };
        }
        private Product MapProduct(product.Product product)
        {
            return new Product()
            {
                Name = product.Name,
                UpdateDate = DateTime.Today,
                CreateDate = DateTime.Today,
                PricePerGram = product.PricePerGram

            };
        }


        #endregion


    }
}
