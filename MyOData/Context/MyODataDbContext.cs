using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyOData.Models;

namespace MyOData.Context
{
    public class MyODataDbContext: DbContext
    {
        public MyODataDbContext()
            :base("name=MyOData")
        {
        }

        public IDbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
        }
    }
}