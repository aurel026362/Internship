using App.Data.Domain.DomainModels.Concrete;
using App.Data.Interfaces.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        protected readonly DbSet<T> DbSet;

        protected GenericRepository(DbContext context)
        {
            _context = context;
            DbSet = _context.Set<T>();
        }

        public IList<T> GetAll()
        {
            return DbSet.AsNoTracking().ToList();
        }

        public IList<T> GetNext10(int page)
        {
            return  DbSet.Skip(10 * page).Take(10).ToList();
        }

        //public async List<T>> GetAll(Expression<Func<T, bool>> predicate)
        //{
        //    return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        //}


        public T GetById(long id)
        {
            return DbSet.Find(id);
        }

        public void Add(T element)
        {
            if (element == null)
                throw new ArgumentNullException(paramName: nameof(element));

            DbSet.AddAsync(element);
        }

        public void AddRange(IList<T> elements)
        {
            if (elements == null)
                throw new ArgumentNullException(paramName: nameof(elements));

             DbSet.AddRange(elements);
        }

        public void Delete(T element)
        {
            //if (element == null)
            //    throw new EntityNotFoundException(nameof(element));

            DbSet.Remove(element);
        }

        public void Delete(long id)
        {
            T element = DbSet.Find(id);

            //if (element == null)
            //    throw new EntityNotFoundException(nameof(element));

            DbSet.Remove(element);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        
        public long Count => DbSet.Count();
        
    }
}
