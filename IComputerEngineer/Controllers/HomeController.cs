using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IComputerEngineer.Models;
using IComputerEngineer.Data;
using IComputerEngineer.Services;
using IComputerEngineer.Data.FileManager;

namespace IComputerEngineer.Controllers
{
    public class HomeController : Controller
    {
        private IFileManager _fileManager;
        private IRepository<Post> _postRepo;

        public HomeController(IRepository<Post> repository, IFileManager fileManager)
        {
            _fileManager = fileManager;
            _postRepo = repository;
        }
        public IActionResult Index(string category)
        {
            var posts = String.IsNullOrEmpty(category) ? _postRepo.GetAll() : _postRepo.GetAll(category);
            return View(posts);
        }
        public IActionResult Post(int id)
        {
            var post = _postRepo.GetById(id);
            return View(post);
        }
        [HttpGet("[Controller]/Image/(image)")]
        public IActionResult Image(string image)
        {
            var mime = image.Substring(image.LastIndexOf(".") + 1);

            return new FileStreamResult(_fileManager.ImageStream(image), $"image/{mime}");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
