using IComputerEngineer.Models;
using IComputerEngineer.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IComputerEngineer.Data.Repository
{
    public class PostRepository : IRepository<Post>
    {
        private AppDbContext _dbContext;

        public PostRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(int id)
        {
            _dbContext.Posts.Remove(GetById(id));
        }

        public List<Post> GetAll()
        {
            return  _dbContext.Posts.ToList();            
        }

        public Post GetById(int id)
        {
            return _dbContext.Posts.FirstOrDefault(p=>p.Id==id);
        }

        public Post Insert(Post entity)
        {
            _dbContext.Posts.Add(entity);
            return entity;
        }

        public async Task<bool> SaveChangesAsync()
        {

            await _dbContext.SaveChangesAsync();
            return true;
        }

        public Post Update(Post entity)
        {
            _dbContext.Posts.Update(entity);
            return entity;
        }


    }
}
