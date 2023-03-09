using Bazzar.Database;
using Bazzar.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bazzar.Services
{
    public class CatagoriesService
    {
        public List<Catagory> ViewCatagory()
        {
            using (var context = new BazzarContext())
            {
                return context.Catagories.ToList();
                
            }
        }
        public Catagory GetCatagoryById(int Id)
        {
            using (var context = new BazzarContext())
            {
                return context.Catagories.Find(Id);

            }
        }
        public void UpdateCatagory(Catagory catagory)
        {
            using (var context = new BazzarContext())
            {
                context.Entry(catagory).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void SaveCatagory(Catagory catagory)
        {
            using (var context = new BazzarContext())
            {
                context.Catagories.Add(catagory);
                context.SaveChanges();
            }
        }
        public void DeleteCatagory(int id)
        {
            using (var context = new BazzarContext())
            {
                var catagory = context.Catagories.Find(id);
                context.Catagories.Remove(catagory);
                context.SaveChanges();
            }
        }
    }
}
