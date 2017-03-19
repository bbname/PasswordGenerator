using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataServices.Entity;

namespace DataServices.Repository.ReadRepository
{
    public class UserReadRepository : ReadRepository<User> 
    {
        private DbContext _dbContext;
        private DbSet<User> _dbSet;
        private User _user;
        public UserReadRepository(DbContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
            this._dbSet = dbContext.Set<User>();
            _user = new User();
        }

        public bool CheckLogin(string login, string password)
        {
            var exists = _dbSet.Any(u => u.Login == login && u.Password == password);
            _dbContext.Dispose();
            return exists;
        }

        public User GetByLoginPassword(string login, string password)
        {
            var user = _dbSet.Where(u => u.Login == login && u.Password == password).SingleOrDefault();
            _dbContext.Dispose();
            return user;
        }
    }
}
