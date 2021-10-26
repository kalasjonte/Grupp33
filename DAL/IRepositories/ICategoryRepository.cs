using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELS;

namespace DAL
{
    public interface ICategoryRepository<T> : IRepository<T> where T : Category
    {

    }
}
