using System.Collections.Generic;

namespace DAL
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        void DeleteFromName(string name);
        void SaveChanges();
        List<T> GetAll();



    }
}
