using System;
using System.Collections.Generic;

namespace IComputerEngineer.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Body { get; set; } = "";
        public string Image { get; set; } = "";
        public DateTime Created { get; set; } = DateTime.Now;

        public string Description { get; set; } = "";   
        public string Tags { get; set; } = "";
        public string Category { get; set; } = "";

    }
}
