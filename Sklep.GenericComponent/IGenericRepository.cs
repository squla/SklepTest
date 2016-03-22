using System.Collections.Generic;

namespace Sklep.GenericComponent
{
    public interface IGenericRepository<T>
    {
        bool Insert(T t);
        T Delete(int id);
        T Find(int id);
        List<T> FindAll();
    }
}