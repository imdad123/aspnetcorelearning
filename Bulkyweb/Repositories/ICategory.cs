using Bulkyweb.Models;

namespace Bulkyweb.Repositories
{
    public interface ICategory
    {
        public List<Category> GetCategories();
        public Category GetCategory(int id);
    }
}
