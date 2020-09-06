using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace IComputerEngineer.Services
{
    public interface IRepository<TEntity>
    {
        TEntity GetById(int id);
        List<TEntity> GetAll();
        TEntity Update(TEntity entity);
        TEntity Insert(TEntity entity);
        void Delete(int id);

        Task<bool> SaveChangesAsync();
    }
}
