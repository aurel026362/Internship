using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TESTDB.Repository
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        DbContext _context;
        DbSet<T> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        public T FindById(long id)
        {
            return _dbSet.Find(id);
            //return _dbSet.SET(x=>x.Id == id);
        }

        public IEnumerable<T> Get()
        {
            return _dbSet;
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }

        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
