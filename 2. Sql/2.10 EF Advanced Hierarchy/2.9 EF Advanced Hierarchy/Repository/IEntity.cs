using System;
using System.Collections.Generic;
using System.Text;

namespace TESTDB.Repository
{
    public abstract class Entity<T>
    {
        public T Id { get; set; }
    }
}
