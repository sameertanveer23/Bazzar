using Bazzar.Database;
using Bazzar.Entities;


namespace Bazzar.Services
{
    public class CatagoriesService
    {
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
