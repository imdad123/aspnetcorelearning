using Bulkyweb.Models;

namespace Bulkyweb.Repositories
{
    public class CategoryRepo : ICategory
    {
        public List<Category> GetCategories()
        {

            return getDatasource();
        }

        public Category GetCategory(int id)
        {
            return getDatasource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<Category> getDatasource()
        {
            var categories = new List<Category>()
            {
                new Category{ Id=1,Name="cat111" },
                new Category{ Id=2,Name="cat121" },
                new Category{ Id=3,Name="cat131" },
            };
            return categories;
        }
    }
}
