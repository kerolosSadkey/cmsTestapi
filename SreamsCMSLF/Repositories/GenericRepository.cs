using SreamsCMSLF.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SreamsCMSLF.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly CmsDbContext context;
        private readonly DbSet<T> _table;

        public GenericRepository(CmsDbContext _context)
        {
            context = context;
            _table = _context.Set<T>();
           
        }


        public void Add(T entity)
        {
            
            _table.Add(entity);
        }

        public void Delete(T entity)
        {

            _table.Remove(entity);

        }



        public T FindById(int id)
        {
            return _table.Find(id);
        }

        public IQueryable<T> GetALL()
        {

            return _table;
        }

        public void Update(T entity)
        {
            _table.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}