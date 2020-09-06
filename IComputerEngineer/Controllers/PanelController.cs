using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IComputerEngineer.Data.FileManager;
using IComputerEngineer.Models;
using IComputerEngineer.Services;
using IComputerEngineer.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IComputerEngineer.Controllers
{
    [Authorize(Roles ="Admin")]
    public class PanelController : Controller
    {
        private IRepository<Post> _postRepo;
        private IFileManager _fileManager;

        public PanelController(IRepository<Post> repository, IFileManager fileManager)
        {
            _postRepo = repository;
            this._fileManager = fileManager;
        }
        public IActionResult Index()
        {
            var posts = _postRepo.GetAll();
            return View(posts);
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View(new PostViewModel());
            }
            else
            {
                var post = _postRepo.GetById((int)id);
                return View(new PostViewModel
                {
                    Body = post.Body,
                    Id = post.Id,
                    Title = post.Title,

                });
            }
        }
        [HttpPost]
        public async Task<IActionResult> EditAsync(PostViewModel postViewModel)
        {
            var post = new Post
            {
                Title = postViewModel.Title,
                Id = postViewModel.Id,
                Body = postViewModel.Body,
                Image =await _fileManager.SaveImage(postViewModel.Image),
            }; 
            if (post.Id > 0)
            {
                _postRepo.Update(post);
            }
            else
            {
                _postRepo.Insert(post);
            }
            if (_postRepo.SaveChangesAsync().Result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(post);
            }

        }
        public IActionResult Remove(int id)
        {
            _postRepo.Delete(id);
            _postRepo.SaveChangesAsync();
            return RedirectToAction("Index");
        }



    }
}

