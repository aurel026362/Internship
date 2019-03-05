using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_Generics.Repository_pattern
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetUsersList();
        T GetUser(int id);
        void Add(T user);
        void Update(int id, T user);
        void Delete(int id);
    }
}
