using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        void Delete(int index);
        void DeleteFromName(string name);
        void Update(int index, T entity);
        void SaveChanges();
        List<T> GetAll();

    }
}
