using IComputerEngineer.Data.Repository.Abstract;
using IComputerEngineer.Models;
using IComputerEngineer.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IComputerEngineer.Data.Repository
{
    public class PostRepository : IPostRepository
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

            return _dbContext.Posts.ToList();
        }
        public IndexViewModel GetAll(int pageNumber)
        {
            int pageSize = 5;
            // total post count
            int postCount = _dbContext.Posts.Count();
            // how many post you will skip while page loading
            int skipAmount = pageSize * (pageNumber - 1);
            return new IndexViewModel
            {
                PageCount = postCount % pageSize == 0 ? postCount / pageSize : (postCount / pageSize) + 1,
            CurrenPageNumber = pageNumber,
                NextPage = (postCount - pageNumber * pageSize) > 0,
                Posts = _dbContext.Posts
            .Skip(skipAmount)
            .Take(pageSize)
            .ToList()
            };
        }
        public IndexViewModel GetAll(int pageNumber, string category)
        {
            Func<Post, bool> InCategry = (p) => { return p.Category.ToLower().Equals(category.ToLower()); };
            int pageSize = 5;
            int skipAmount = pageSize * (pageNumber - 1);
            int postCount = _dbContext.Posts.Count(InCategry);
            return new IndexViewModel
            {
                PageCount = postCount % pageSize == 0 ? postCount / pageSize : (postCount / pageSize) + 1,
                Category = category,
                CurrenPageNumber = pageNumber,
                NextPage = (postCount - pageNumber * pageSize) > 0,
                Posts = _dbContext.Posts
            .Where(InCategry)
            .Skip(skipAmount)//minus for first page. we dont wanan skipanything at first page
            .Take(pageSize)
            .ToList()
            };
        }
        public List<Post> GetAll(string category)
        {
            Func<Post, bool> InCategry =
                (p) => { return p.Category.ToLower().Equals(category.ToLower()); };
            return _dbContext.Posts.Where(InCategry).ToList();
        }

        public Post GetById(int id)
        {
            return _dbContext.Posts
                .Include(p => p.MainComments)
                    .ThenInclude(mc => mc.SubComments)
                .FirstOrDefault(p => p.Id == id);
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
