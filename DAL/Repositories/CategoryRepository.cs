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
        List<Category> listOfCategories;
        SerializerXml xml = new SerializerXml();

        public CategoryRepository()
        {
            listOfCategories = new List<Category>();
            listOfCategories = xml.DeserializeCategory();
        }

        public void Create(Category entity)
        {
            listOfCategories.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
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
            return catQuery.First();
        }

        public void SaveChanges()
        {
            xml.SerializeCategory(listOfCategories);
        }

        public List<Category> SortDesending()
        {
            throw new NotImplementedException();
        }

        public List<Podcast> SortedPodcastOnCategory(Category cat)
        {
            throw new NotImplementedException();
        }

        public void Update(int index, Category entity)
        {
            throw new NotImplementedException();
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
