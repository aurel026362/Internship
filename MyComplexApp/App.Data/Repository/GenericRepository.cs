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
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        
    
        private readonly DbContext _context;
        protected readonly DbSet<T> DbSet;

        protected GenericRepository(DbContext context)
        {
            _context = context;
            DbSet = _context.Set<T>();
        }

        public Task<List<T>> GetAll()
        {
            return DbSet.AsNoTracking().ToListAsync();
        }

        public IList<T> GetNext10(int skipNr)
        {
            return  DbSet.Skip(10*skipNr).Take(10).ToList();
        }

        //public async List<T>> GetAll(Expression<Func<T, bool>> predicate)
        //{
        //    return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        //}


        public async Task<T> GetById(long id)
        {
            return await DbSet.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task Add(T element)
        {
            if (element == null)
                throw new ArgumentNullException(paramName: nameof(element));

            await DbSet.AddAsync(element);
        }

        public async Task AddRange(IList<T> elements)
        {
            if (elements == null)
                throw new ArgumentNullException(paramName: nameof(elements));

            await DbSet.AddRangeAsync(elements);
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

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
        
        public long Count => DbSet.Count();

        Task<IList<T>> IRepository<T>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
