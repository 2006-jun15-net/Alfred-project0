using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryApp.Interfaces
{
    public interface IGenericRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert();
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}
