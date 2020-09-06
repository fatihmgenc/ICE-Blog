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

namespace IComputerEngineer.Controllers
{
    public class HomeController : Controller
    {

        private IRepository<Post> _postRepo;

        public HomeController(IRepository<Post> repository)
        {
            _postRepo = repository;
        }
        public IActionResult Index(int id)
        {
            var posts = _postRepo.GetAll();
            return View(posts);
        }
        public IActionResult Post(int id)
        {
            var post = _postRepo.GetById(id);
            return View(post);
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
