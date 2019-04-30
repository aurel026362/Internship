using App.Data.Domain.DomainModels.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Interfaces.RepositoryInterfaces
{
    public interface IGenericRepository<T> where T : class
    {

        T GetById(long Id);

        IList<T> GetNext10(int page);

        IList<T> GetAll();
        
        //Task<IList<T>> GetAll(Expression<Func<T, bool>> predicate);

        void Add(T element);

        void AddRange(IList<T> elements);

        void Delete(T element);

        void Delete(long id);

        void Save();

        long Count { get; }
    }
}
