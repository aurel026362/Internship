using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Data.Repository
{
    public static class RepositoryExtensionMethod
    {
        private const int _TakeNr = 10;

        public static IList<T> SkipTakeNext10<T>(this IQueryable<T> queryable, int page)
        {
            var list = queryable.Skip(page * _TakeNr).Take(_TakeNr).ToList();

            return list;
        }

        public static IList<T> TakeNext10<T>(this IQueryable<T> queryable)
        {
            var list = queryable.Take(_TakeNr).ToList();

            return list;
        }
    }
}
