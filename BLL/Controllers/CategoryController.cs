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

        public void SerializeCat(List<Category> categorys)
        {
            SerializerXml xml = new SerializerXml();
            xml.SerializeCategory(categorys);
        }

        public List<Category> DeSerializeCat()
        {
            SerializerXml xml = new SerializerXml();
            return xml.DeserializeCategory();
        }

        public Category GetCategoryByName(string name)
        {
             return categoryRepo.GetCategoryFromName(name);

        }

        public List<Category> GetAllCategories()
        {
            return categoryRepo.GetAll();
        }

        public void newCategoryList(List<Category> list)
        {
            categoryRepo.UpdateCategoryList(list);
        }

        public void Save()
        {
            categoryRepo.SaveChanges();
        }

        public void UpdateCategoryName(string name, string newName)
        {
            categoryRepo.UpdateCategoryFromName(name, newName);
        }
    }

    
}
