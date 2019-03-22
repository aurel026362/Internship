using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TESTDB.Repository
{
    interface IRepository<T> where T : IEntity
    {
        void Add(T item);
        T FindById(long id);
        IEnumerable<T> Get();
        void Remove(T item);
        void Update(T item);
    }
}
