using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SreamsCMSLF.Repositories
{
    public interface IGenericRepository<T>
    {
        IQueryable<T> GetALL();


        T FindById(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
