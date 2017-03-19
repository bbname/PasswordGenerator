using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices.Repository.ReadRepository
{
    interface IReadRepository<T> where T : Entity.Entity
    {
        T GetById(int id);
        List<T> GetAll();
    }
}
