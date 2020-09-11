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
using IComputerEngineer.Models.Comments;
using IComputerEngineer.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using IComputerEngineer.Data.Repository.Abstract;

namespace IComputerEngineer.Controllers
{
    public class HomeController : Controller
    {
        private IFileManager _fileManager;
        private IPostRepository _postRepo;
        private ISubCommentRepository _subCRepo;

        public HomeController(IPostRepository postRepository, ISubCommentRepository subCommentRepository, IFileManager fileManager)
        {
            _fileManager = fileManager;
            _postRepo = postRepository;
            _subCRepo = subCommentRepository;
            var comment = new MainComment();
        }
        public IActionResult Index(int pageNumber, string category)
        {
            if (pageNumber < 1)
                return RedirectToAction("Index", new { pageNumber = 1, category });
            if (String.IsNullOrEmpty(category))
            {
                var viewModel = _postRepo.GetAll(pageNumber);
                return View(viewModel);
            }
            else
            {
                var viewModel = _postRepo.GetAll(pageNumber,category);
                return View(viewModel);
            }

        }
        public IActionResult Post(int id)
        {
            var post = _postRepo.GetById(id);
            return View(post);
        }
        [HttpGet("[Controller]/Image/(image)")]
        [ResponseCache(CacheProfileName = "Monthly")]
        public IActionResult Image(string image)
        {
            var mime = image.Substring(image.LastIndexOf(".") + 1);

            return new FileStreamResult(_fileManager.ImageStream(image), $"image/{mime}");
        }

        public async Task<IActionResult> Comment(CommentViewModel commentVM)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Post", new { id = commentVM.PostId });
            var post = _postRepo.GetById(commentVM.PostId);
            if (commentVM.MainCommentId == 0)
            {
                post.MainComments = post.MainComments ?? new List<MainComment>();
                post.MainComments.Add(new MainComment
                {
                    Created = DateTime.Now,
                    Messege = commentVM.Messege,
                });
                _postRepo.Update(post);
                await _postRepo.SaveChangesAsync();
            }
            else
            {
                var comment = new SubComment
                {
                    Created = DateTime.Now,
                    Messege = commentVM.Messege,
                    MainCommentId = commentVM.MainCommentId,
                };
                _subCRepo.Insert(comment);
                await _subCRepo.SaveChangesAsync();
            }
            return RedirectToAction("Index");
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
