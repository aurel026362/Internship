using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text;
using _2._9_EF_Advanced_Hierarchy.Repository;
using System.Collections.Generic;

namespace _2._9_EF_Advanced_Hierarchy
{
    public class GenericRepository<T, TID> : BaseRepository<T, TID> where T : Entity<TID>
    {
        DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public override void Add(T item)
        {
            _context.Set<T>().Add(item);
            _context.SaveChanges();
        }

        public override T FindById(TID id)
        {
            return _context.Set<T>().Find(id);
        }

        public override IList<T> Get()
        {
            return _context.Set<T>().ToList<T>();
        }

        public override void Remove(T item)
        {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }

        public override void Update(T item)
        {
            //_context.Entry(item).State = EntityState.Modified;
            _context.Set<T>().Update(item);
            _context.SaveChanges();
        }
    }
}
