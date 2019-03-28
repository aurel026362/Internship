using _2._9_EF_Advanced_Hierarchy.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._9_EF_Advanced_Hierarchy.Repository
{
    public abstract class IRepository<T, TID> where T : Entity<TID>
    {
        public abstract void Add(T item);
        
        public abstract T FindById(TID id);

        public abstract IList<T> Get();

        public abstract void Remove(T item);

        public abstract void Update(T item);
    }
}
