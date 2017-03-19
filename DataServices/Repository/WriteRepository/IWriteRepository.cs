using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.Repository.WriteRepository
{
    interface IWriteRepository<T> where T : Entity.Entity
    {
        void Create(T entity);
        void Delete(T entity);
    }
}
