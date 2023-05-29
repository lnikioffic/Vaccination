using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab6new;
using Lab6new.Models.Interface;

namespace Lab6new.Controllers
{
    internal class CRUDCardController<T>
        where T : class, ICard
    {
        /*public static Predicate<T> And<T>(params Predicate<T>[] predicates)
        {
            return delegate (T item)
            {
                foreach (Predicate<T> predicate in predicates)
                {
                    if (!predicate(item))
                    {
                        return false;
                    }
                }
                return true;
            };
        }*/

        public List<T> GetData(Predicate<T> filter)
        {
            using (var db = new Lab3newContext())
            {
                var model = db
                    .GetType()
                    .GetProperties()
                    .Where(x => x.PropertyType.Equals(typeof(DbSet<T>)))
                    .First()
                    .GetValue(db);

                if (model as DbSet<T> != null)
                    return ((DbSet<T>)model)
                        .AsEnumerable()
                        .Where(x => filter(x))
                        .AsQueryable()
                        .ToList();

                return new List<T>();
            }
        }

        public void Add(T dataObject)
        {
            using (var db = new Lab3newContext())
            {
                var model = db
                    .GetType()
                    .GetProperties()
                    .Where(x => x.PropertyType.Equals(typeof(DbSet<T>)))
                    .First()
                    .GetValue(db);

                if (model as DbSet<T> != null)
                    ((DbSet<T>)model).Add(dataObject);

                db.SaveChanges();
            }
        }

        public void Update(T dataObject)
        {
            using (var db = new Lab3newContext())
            {
                var model = db
                    .GetType()
                    .GetProperties()
                    .Where(x => x.PropertyType.Equals(typeof(DbSet<T>)))
                    .First()
                    .GetValue(db);

                if (model as DbSet<T> != null)
                    ((DbSet<T>)model).Update(dataObject);

                db.SaveChanges();
            }
        }

        public void Delete(T dataObject)
        {
            using (var db = new Lab3newContext())
            {
                var model = db
                    .GetType()
                    .GetProperties()
                    .Where(x => x.PropertyType.Equals(typeof(DbSet<T>)))
                    .First()
                    .GetValue(db);

                if (model as DbSet<T> != null)
                    ((DbSet<T>)model).Remove(dataObject);

                db.SaveChanges();
            }
        }
    }
}
