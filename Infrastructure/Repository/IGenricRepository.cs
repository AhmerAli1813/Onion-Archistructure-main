using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.EntityFramework;
using Domain.Models;
namespace Infrastructure.Repository
{
     public interface IGenricRepository<T> where T : BaseEnity
    {
        IEnumerable<T> GetAll();
        T GetT (long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
            
     }
}
