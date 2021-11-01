using DAL;
using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class CategoryController
    {
        public ICategoryRepository<Category> categoryRepo;

        public CategoryController()
        {
            categoryRepo = new CategoryRepository();
        }

        public void createCategory(string name)
        {
            Category category = new Category(name);
            categoryRepo.Create(category);
        }

        public Category GetCategoryByName(string name)
        {
             return categoryRepo.GetCategoryFromName(name);

        }

        public List<Category> GetAllCategories()
        {
            return categoryRepo.GetAll();
        }

        public void UpdateCategoryName(string name, string newName)
        {
            categoryRepo.UpdateCategoryFromName(name, newName);
        }

        public void DeleteCategoryOnName(string name)
        {
            categoryRepo.DeleteCategoryOnName(name);
        }
    }

    
}
