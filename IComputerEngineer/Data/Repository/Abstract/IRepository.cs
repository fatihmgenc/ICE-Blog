using IComputerEngineer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace IComputerEngineer.Data.Repository.Abstract
{
    public interface IRepository<TEntity>
    {
        TEntity GetById(int id);
        List<TEntity> GetAll();
        TEntity Update(TEntity entity);
        TEntity Insert(TEntity entity);
        void Delete(int id);

        Task<bool> SaveChangesAsync();
        List<Post> GetAll(string category);
    }
}
