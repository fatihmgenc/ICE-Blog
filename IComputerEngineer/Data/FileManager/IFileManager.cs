using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IComputerEngineer.Data.FileManager
{
    public interface IFileManager
    {
        Task<string> SaveImage(IFormFile images);
    }
}
