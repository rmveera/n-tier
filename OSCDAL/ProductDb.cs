using OSCBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSCDAL
{
    public class ProductDb : BaseRepositoryDb
    {
        
        public IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> products = oscDbContext.Products.ToList();
            return products;
        }
        public Product GetProductById(int Id)
        {
            Product product = oscDbContext.Find<Product>(Id) ?? null;
            return product;
        }
        public void AddProduct(Product product)
        {
            if(product!=null)
               oscDbContext.Add<Product>(product);
        }
        public void DeleteProduct(Product product)
        {
            if(product!=null)
               oscDbContext.Remove<Product>(product);
        }
        public void UpdateProduct(Product product)
        {
            if (product != null) { 
                oscDbContext.Update<Product>(product);
            }
        }
       
    }
}
