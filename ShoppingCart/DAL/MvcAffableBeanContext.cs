using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ShoppingCartApp.Models;

namespace ShoppingCartApp.DAL
{
    public class MvcAffableBeanContext:DbContext

    {
        public MvcAffableBeanContext() : base("MvcAffableBean")
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<CustomerOrder> CustomerOrders { get; set; }

        public DbSet<OrderedProduct> Orderedproducts { get; set; }

        public DbSet<Cart> Carts { get; set; }
        

        public System.Data.Entity.DbSet<ShoppingCartApp.Models.RegisterModel> RegisterModels { get; set; }
    }
}