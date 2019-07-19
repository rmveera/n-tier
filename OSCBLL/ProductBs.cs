using System;
using OSCBOL;
using OSCDAL;
using System.Linq;
using System.Collections.Generic;

namespace OSCBLL
{
    public class ProductBs
    {
        ProductDb productDb;
        public ProductBs() {
            productDb = new ProductDb();
        }

        public IEnumerable<Product> GetAllProducts() {
            IEnumerable<Product> allproducts = productDb.GetAllProducts();
            foreach(var product in allproducts){
                if (product.ProductPrice >= 1000) {
                    product.Status = "A";
                } else {
                    product.Status = "B";
                }
            }
                return allproducts.Where(x=>x.Status=="A");
        }
        public Product GetProductById(int Id) {
            return productDb.GetProductById(Id);
        }
        public void AddProduct(Product product) {
            if (product != null)
                productDb.AddProduct(product);
        }
        public void DeleteProduct(Product product)
        {
            if (product != null)
                productDb.DeleteProduct(product);
        }
        public void UpdateProduct(Product product)
        {
            if (product != null) {
                productDb.UpdateProduct(product);
            }
        }
        public void Save() {
            productDb.Save();
        }
    }
}
