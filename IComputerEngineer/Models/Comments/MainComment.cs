using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IComputerEngineer.Models.Comments
{
    public class MainComment:Comment
    {
        public List<SubComment> SubComments { get; set; }
    }
}
