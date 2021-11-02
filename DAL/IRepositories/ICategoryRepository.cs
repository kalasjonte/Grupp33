using MODELS;

namespace DAL
{
    public interface ICategoryRepository<T> : IRepository<T> where T : Category
    {
        Category GetCategoryFromName(string name);
        void UpdateCategoryFromName(string name, string newName);
        void DeleteCategoryOnName(string name);
    }
}
