using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ItemRepository : IItemRepository<Item>
    {
        //Generella metoder för repositorie patterns:
        public void Create(Item entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(int index, Item entity)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetAll()
        {
            throw new NotImplementedException();
        }

        //Specifika för IItemRepositories:
        public Item GetByDescription(string desc)
        {
            throw new NotImplementedException();
        }

        public Item GetByGuid(string guid)
        {
            throw new NotImplementedException();
        }

        public Item GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteFromName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
