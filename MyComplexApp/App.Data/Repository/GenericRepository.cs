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
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _context;
        //protected readonly DbSet<T> DbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            //DbSet = _context.Set<T>();
        }

        public IList<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking().ToList();
        }

        public IList<T> GetNext10(int page)
        {
            return _context.Set<T>().Skip(10 * page).Take(10).ToList();
        }

        //public async List<T>> GetAll(Expression<Func<T, bool>> predicate)
        //{
        //    return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        //}


        public T GetById(long id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Add(T element)
        {
            if (element == null)
                throw new ArgumentNullException(paramName: nameof(element));

            _context.Set<T>().AddAsync(element);
        }

        public void AddRange(IList<T> elements)
        {
            if (elements == null)
                throw new ArgumentNullException(paramName: nameof(elements));

            _context.Set<T>().AddRange(elements);
        }

        public void Delete(T element)
        {
            //if (element == null)
            //    throw new EntityNotFoundException(nameof(element));

            _context.Set<T>().Remove(element);
        }

        public void Delete(long id)
        {
            T element = _context.Set<T>().Find(id);

            //if (element == null)
            //    throw new EntityNotFoundException(nameof(element));

            _context.Set<T>().Remove(element);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        
        public long Count => _context.Set<T>().Count();
        
    }
}
