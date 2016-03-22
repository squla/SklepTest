using System.Collections.Generic;
using Sklep.GenericComponent;

namespace Sklep.Infrastructure.Repositories
{
    public class GenericCRUDRepositories<T> : IGenericRepository<T>
    {
        protected List<T> list = new List<T>(); 
        public bool Insert(T t)
        {
            if (t == null) return false;
            list.Add(t);
            return true;
        }

        public virtual T Delete(int id)
        {
            T t = Find(id);
            if (t != null)
            {
                list.Remove(t);
            }
            return t;
        }

        public virtual T Find(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<T> FindAll()
        {
            return list;
        }
    }
}