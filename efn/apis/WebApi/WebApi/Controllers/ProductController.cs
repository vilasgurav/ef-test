using Orchastrator.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using product = Domain.Layer.Product;

namespace WebApi.Controllers
{
    [RoutePrefix("api/v1/product")]
    public class ProductController : ApiController
    {
        IProductOrc prod;

        [HttpGet]
        [Route("get-product")]
        public IHttpActionResult GetProduct(short id)
        {
            prod = new ProductOrc();
            return Ok(prod.GetProduct(id));
        }

        [HttpPost]
        [Route("create-product")]
        public IHttpActionResult CreateProduct(product.Product product)
        {
            prod = new ProductOrc();
            return Ok(prod.CreateProduct(product));
        }

        [HttpPatch]
        [Route("update-product")]
        public IHttpActionResult UpdateProduct(product.Product product)
        {
            prod = new ProductOrc();
            return Ok(prod.UpdateProduct(product));
        }


    }
}
