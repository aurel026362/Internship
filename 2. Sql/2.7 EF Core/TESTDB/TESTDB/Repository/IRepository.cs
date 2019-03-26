using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TESTDB.Repository
{
    interface IRepository<T> where T : Entity<T>
    {
        void Add(T item);
        T FindById(T id);
         IQueryable<T> Get();
        void Remove(T item);
        void Update(T item);
    }
}
