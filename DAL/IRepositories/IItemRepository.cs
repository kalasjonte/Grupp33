using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELS;

namespace DAL
{
    interface IItemRepository<T> : IRepository<T> where T : Item
    {
        T GetByName(string name);
        T GetByDescription(string desc);
        T GetByGuid(string guid);

    }
}   
