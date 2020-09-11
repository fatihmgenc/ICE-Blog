using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IComputerEngineer.Data.FileManager;
using IComputerEngineer.Data.Repository.Abstract;
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
        private IPostRepository _postRepo;
        private IFileManager _fileManager;

        public PanelController(IPostRepository repository, IFileManager fileManager)
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
                    CurrentImage = post.Image,
                    Category = post.Category,
                    Tags = post.Tags,
                    Description = post.Description,
                });
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PostViewModel postViewModel)
        {
            var post = new Post
            {
                Title = postViewModel.Title,
                Id = postViewModel.Id,
                Body = postViewModel.Body,
                Description = postViewModel.Description,
                Tags = postViewModel.Tags,
                Category = postViewModel.Category,
            };
            if (postViewModel.Image == null)
            {
                post.Image = postViewModel.CurrentImage;
            }
            else
            {
                if (!string.IsNullOrEmpty(postViewModel.CurrentImage))
                    _fileManager.RemoveImage(postViewModel.CurrentImage);
                post.Image = await _fileManager.SaveImage(postViewModel.Image);
            }
            if (post.Id > 0)
            {
                _postRepo.Update(post);
            }
            else
            {
                _postRepo.Insert(post);
            }
            if (await _postRepo.SaveChangesAsync())
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(post);
            }

        }
        public async Task<IActionResult> Remove(int id)
        {
            _postRepo.Delete(id);
            await _postRepo.SaveChangesAsync();
            return RedirectToAction("Index");
        }



    }
}

