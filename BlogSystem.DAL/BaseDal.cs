using BlogSystem.IDAL;
using BlogSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.DAL
{
    public class BaseDal<T> : IBaseDal<T> where T : BaseEntity, new()
    {
        
        public T Add(T entity)
        {
            
        }

        public bool Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable GetAll(Guid id)
        {
            throw new NotImplementedException();
        }

        public T GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Guid id)
        {
            T entity = new T();
            entity.
            throw new NotImplementedException();
        }
    }
}
