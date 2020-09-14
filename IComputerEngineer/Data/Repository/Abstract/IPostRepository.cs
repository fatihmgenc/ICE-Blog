using IComputerEngineer.Models;
using IComputerEngineer.ViewModels;

namespace IComputerEngineer.Data.Repository.Abstract
{
    public interface IPostRepository : IRepository<Post>
    {
        IndexViewModel GetAll(int pageNumber);
        IndexViewModel GetAll(int pageNumber, string category);
    }

}
