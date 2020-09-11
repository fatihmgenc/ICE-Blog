using IComputerEngineer.Data.Repository.Abstract;
using IComputerEngineer.Models;
using IComputerEngineer.Models.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IComputerEngineer.Data.Repository
{
    public class SubCommentRepository : ISubCommentRepository
    {
        private AppDbContext _dbContext;

        public SubCommentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubComment> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAll(string category)
        {
            throw new NotImplementedException();
        }

        public SubComment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public SubComment Insert(SubComment subCom)
        {
            _dbContext.SubComments.Add(subCom);
            return subCom;

        }

        public async Task<bool> SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public SubComment Update(SubComment entity)
        {
            throw new NotImplementedException();
        }
    }
}
