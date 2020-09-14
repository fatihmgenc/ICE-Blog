using IComputerEngineer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IComputerEngineer.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Post> Posts{ get; set; }
        public bool NextPage{ get; set; }
        public int PageCount { get; set; }
        public int CurrenPageNumber { get; set; }
        public string Category { get;  set; }
    }
}
