using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Domain.DomainModels.Concrete
{
    public abstract class Entity<T>
    {
        public T Id { get; set; }
    }
}
