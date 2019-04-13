using App.Data.Domain.DomainModels.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Interfaces.RepositoryInterfaces
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        Task<List<T>> GetAll();

        Task<List<T>> GetAll(Expression<Func<T, bool>> predicate);

        Task<T> GetById(long id);

        Task Add(T element);

        Task AddRange(IList<T> elements);

        void Delete(T element);

        void Delete(long id);

        void DeleteRange(IEnumerable<T> elements);
        void DeleteRange(IEnumerable<long> elementsIds);

        Task Save();

        long Count { get; }
    }
}
