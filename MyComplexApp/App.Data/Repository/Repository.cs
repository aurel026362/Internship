using App.Data.Domain.DomainModels.Concrete;
using App.Data.Interfaces.RepositoryInterfaces;
using App.Infrastructure.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly DbContext _context;
        protected readonly DbSet<T> DbSet;

        protected Repository(DbContext context)
        {
            _context = context;
            DbSet = _context.Set<T>();
        }

        public async Task<List<T>> GetAll()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }


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
            if (element == null)
                throw new EntityNotFoundException(nameof(element));

            DbSet.Remove(element);
        }

        public void Delete(long id)
        {
            T element = DbSet.Find(id);

            if (element == null)
                throw new EntityNotFoundException(nameof(element));

            DbSet.Remove(element);
        }

        public void DeleteRange(IEnumerable<T> elements)
        {
            DbSet.RemoveRange(elements);
        }

        public void DeleteRange(IEnumerable<long> elementsIds)
        {
            List<T> elements = DbSet.Where(t => elementsIds.Contains(t.Id)).ToList();

            DbSet.RemoveRange(elements);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public long Count => DbSet.Count();

        #region DisposePattern

        private void ReleaseUnmanagedResources()
        {
            // TODO release unmanaged resources here
        }

        protected virtual void Dispose(bool disposing)
        {
            ReleaseUnmanagedResources();
            if (disposing)
            {
                _context?.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Repository()
        {
            Dispose(false);
        }

        #endregion
    }
}
