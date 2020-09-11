using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace IComputerEngineer.Models.Comments
{
    public class Comment
    {
        public int Id { get; set; }
        public string  Messege { get; set; }
        public DateTime Created { get; set; }
    }
}
