using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.Repository.ReadRepository
{
    public class ReadRepository<T> : IReadRepository<T> where T : Entity.Entity
    {
        private DbContext _context;
        private DbSet<T> _dbSet;

        public ReadRepository(DbContext context)
        {
            this._context = context;
            this._dbSet = context.Set<T>();
        }
        public List<T> GetAll()
        {
            List<T> query = _dbSet.ToList();
            return query;
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
    }
}
