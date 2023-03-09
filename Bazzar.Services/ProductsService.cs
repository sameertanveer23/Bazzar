using Bazzar.Database;
using Bazzar.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bazzar.Services
{
    public class ProductService
    {
        public List<Product> ViewProduct()
        {
            using (var context = new BazzarContext())
            {
                return context.Products.ToList();
                
            }
        }
        public Product GetProductById(int Id)
        {
            using (var context = new BazzarContext())
            {
                return context.Products.Find(Id);

            }
        }
        public void UpdateProduct(Product product)
        {
            using (var context = new BazzarContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void SaveProduct(Product product)
        {
            using (var context = new BazzarContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void DeleteProduct(int id)
        {
            using (var context = new BazzarContext())
            {
                var product = context.Products.Find(id);
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}
