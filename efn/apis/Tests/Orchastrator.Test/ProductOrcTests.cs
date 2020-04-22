using NUnit.Framework;
using System;
using Moq;
using Repository;
using Orchastrator.Product;

namespace Orchastrator.Test
{
    [TestFixture]
    public class ProductOrcTests
    {
        private Mock<IProductRepository> _productRep;
        private IProductOrc _productOrc;

        [SetUp]
        public void Eetup()
        {
            _productRep = new Mock<IProductRepository>();
        }
        [Test]
        public void GetProduct_Test()
        {
            _productRep.Setup(x => x.GetProduct(1))
                .Returns(new Domain.Layer.Product.Product()
                {
                    Id = 1,
                    CreateDate = DateTime.Today,
                    Name = "Gold",
                    PricePerGram = 4500,
                    UpdateDate = DateTime.Today
                });
            _productOrc = new ProductOrc();
            var result = _productOrc.GetProduct(1);

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void CreateProduct_Test()
        {
            _productRep.Setup(x => x.CreateProduct(new Domain.Layer.Product.Product()
            {
                Id = 1,
                CreateDate = DateTime.Today,
                Name = "Gold",
                PricePerGram = 4500,
                UpdateDate = DateTime.Today
            }))
            .Returns(true);
            var result = _productOrc.GetProduct(1);

            Assert.That(result, Is.True);
        }

        [Test]
        public void UpdateProduct_Test()
        {
            _productRep.Setup(x => x.UpdateProduct(new Domain.Layer.Product.Product()
            {
                Id = 1,
                CreateDate = DateTime.Today,
                Name = "Gold",
                PricePerGram = 4500,
                UpdateDate = DateTime.Today
            }))
            .Returns(true);
            var result = _productOrc.GetProduct(1);

            Assert.That(result, Is.True);
        }
    }
}
