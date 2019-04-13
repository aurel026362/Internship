using App.Data.Domain.DomainModels.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Interfaces.RepositoryInterfaces
{
    public abstract class BaseRepository<T, TID> where T : Entity
    {
        public abstract void Add(T item);
        
        public abstract T FindById(TID id);

        public abstract IList<T> Get();

        public abstract void Remove(T item);

        public abstract void Update(T item);
    }
}
