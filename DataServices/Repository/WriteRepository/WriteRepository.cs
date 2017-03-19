using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Extensions;

namespace DataServices.Repository.WriteRepository
{
    class WriteRepository<T> : IWriteRepository<T> where T : Entity.Entity
    {
        private DbContext _context;
        private DbSet<T> _dbSet;

        public WriteRepository(DbContext context)
        {
            this._context = context;
            this._dbSet = context.Set<T>();
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
