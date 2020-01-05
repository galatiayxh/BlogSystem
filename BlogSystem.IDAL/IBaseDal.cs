using BlogSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.IDAL
{
    public interface IBaseDal<T> where T :BaseEntity
    {
        T Add(T entity);
        bool Edit(T entity);
        bool Remove(Guid id);
        IQueryable GetAll(Guid id);
        T GetOne(Guid id);
    }
}
