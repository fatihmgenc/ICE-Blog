using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IComputerEngineer.ViewModels
{
    public class CommentViewModel
    {
        [Required]
        public int PostId { get; set; }
        [Required]
        public int MainCommentId { get; set; }
        [Required]
        public string Messege { get; set; }
        [Required]
        public string Author { get; set; }
    }
}
