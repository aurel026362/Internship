using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TESTDB.Repository
{
    public class Repository<TModel> : IRepository<TModel>  where TModel : Entity<TModel>
    { 
        DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public void Add(TModel item)
        {
            _context.Set<TModel>().Add(item);
            _context.SaveChanges();
        }

        public TModel FindById(long id)
        {
            return _context.Set<TModel>().Find(id);
        }

        public TModel FindById(TModel id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TModel> Get()
        {
            return _context.Set<TModel>();
        }

        public void Remove(TModel item)
        {
            _context.Set<TModel>().Remove(item);
            _context.SaveChanges();
        }

        public void Update(TModel item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
