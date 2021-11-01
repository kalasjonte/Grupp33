using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepository : ICategoryRepository<Category>
    {
        SerializerXml xml = new SerializerXml();
        List<Category> listOfCategories;

        public CategoryRepository()
        {
            listOfCategories = new List<Category>();
            listOfCategories = GetAll();
        }

        public void Create(Category entity)
        {
            listOfCategories.Add(entity);
            SaveChanges();
            GetAll();
        }


        public void DeleteCategoryOnName(string name)
        {
            var catQueryList = from cat in listOfCategories
                               where cat.Name != name
                               select cat;
            listOfCategories = catQueryList.ToList();
            SaveChanges();
            GetAll();
        }

        public void DeleteFromName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return listOfCategories = xml.DeserializeCategory();
        }

        public Category GetCategoryFromName(string name)
        {
            var catQuery = from cat in listOfCategories
                           where cat.Name == name
                           select cat;
            if (catQuery.Count() > 0)
            {
                return catQuery.First();
            }
            else return null;
        }

        public void SaveChanges()
        {
            xml.SerializeCategory(listOfCategories);
        }

        public void UpdateCategoryFromName(string name, string newName)
        {
            var query = from cat in listOfCategories
                        where cat.Name == name
                        select cat;

            var query2 = from cat in listOfCategories
                        where cat.Name != name
                        select cat;

            listOfCategories = query2.ToList();
            Category category = query.First();
            category.Name = newName;
            Create(category);
        }

        public void UpdateCategoryList(List<Category> categorylist)
        {
            listOfCategories = categorylist;
            SaveChanges();
        }
    }
}
