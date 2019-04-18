using App.Data.Domain.DomainModels.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Interfaces.RepositoryInterfaces
{
    public interface IRepository<T> where T : Entity 
    {

        Task<T> GetById(long Id);

        IList<T> GetNext10(int skipNr);

        Task<IList<T>> GetAll();
        
        //Task<IList<T>> GetAll(Expression<Func<T, bool>> predicate);

        Task Add(T element);

        Task AddRange(IList<T> elements);

        void Delete(T element);

        void Delete(long id);

        Task Save();

        long Count { get; }
    }
}
