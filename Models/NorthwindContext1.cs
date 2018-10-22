using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityFWExamples1.Models
{
    public class NorthwindContext1 : DbContext
    {
        public NorthwindContext1()
            :base("name=NorthwindConnection1")
        {

        }
        public DbSet<Category1> CategoriesTable { get; set; }
        public DbSet<Product1> ProductsTable { get; set; }
    }
}