using Domain.EntityFramework;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class GenricRepository<T> : IGenricRepository<T> where T : BaseEnity
    {
        public readonly ApplicationDbContext _dbContext;
        private DbSet<T> Entities;

        public GenricRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            this.Entities = _dbContext.Set<T>();
        }

        public void Delete(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("Entity Missings");
            }
            else
            {
                Entities.Remove(entity);
                _dbContext.SaveChanges();
            }
            
        }

        public IEnumerable<T> GetAll()
        {
            return Entities.AsEnumerable();
        }

        public T GetT(long id)
        {
            return Entities.SingleOrDefault(s => s.Id == id);
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity Missings");
            }
            else
            {
                Entities.Add(entity);
                _dbContext.SaveChanges();
            }
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity Missings");
            }
            else
            {
                Entities.Remove(entity);
                
            }
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity Missings");
            }
            else
            {
                Entities.Update(entity);
                _dbContext.SaveChanges();
            }
        }
    }
}
