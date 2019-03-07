using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_Generics.Repository_pattern
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> GetUsersList();
        T GetUser(int id);
        void Add(T entity);
        void Update(int id, T entity);
        void Delete(int id);
    }
}
