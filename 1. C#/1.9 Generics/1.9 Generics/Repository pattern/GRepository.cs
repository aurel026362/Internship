using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_Generics.Repository_pattern
{
    class GRepository<T> : IRepository<T> where T : IEntity
    {
        List<T> list = new List<T>();

        public GRepository(List<T> newList)
        {
            list = newList;
        }

        public void Add(T user)
        {
            list.Add(user);
        }

        public void Delete(int id)
        {
            list.Remove(list.Find(x => x.Id == id));
        }

        public T GetUser(int id)
        {
            return list.Find(x => x.Id == id);
        }

        public IEnumerable<T> GetUsersList()
        {
            return list;
        }

        public void Update(int id, T newUser)
        {
            list.Remove(list.Find(x => x.Id == id));
            list.Add(newUser);
        }
    }
}
