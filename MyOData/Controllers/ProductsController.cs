using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.OData;
using MyOData.Context;
using MyOData.Models;

namespace MyOData.Controllers
{
    public class ProductsController : ODataController
    {
        private readonly MyODataDbContext _db = new MyODataDbContext();

        private bool ProductExists(int key)
        {
            return _db.Products.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<Product> Get()
        {
            return _db.Products;
        }

        [EnableQuery]
        public SingleResult<Product> Get([FromODataUri] int key)
        {
            IQueryable<Product> result = _db.Products.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}