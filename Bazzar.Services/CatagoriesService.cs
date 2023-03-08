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
        public void SaveCatagory(Catagory catagory)
        {
            using (var context = new BazzarContext())
            {
                context.Catagories.Add(catagory);
                context.SaveChanges();
            }
        }
    }
}
