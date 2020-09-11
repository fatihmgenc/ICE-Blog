using IComputerEngineer.Models;
using IComputerEngineer.Services;
using IComputerEngineer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IComputerEngineer.Data.Repository.Abstract
{
    public interface IPostRepository:IRepository<Post>
    {
        IndexViewModel GetAll(int pageNumber);
        IndexViewModel GetAll(int pageNumber,string category);
    }

}
