using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Domain.Entities
{
    public class About
    {
        public int AboutId { get; set; }
        public int Title{ get; set; }
        public int Description{ get; set; }
        public string ImageUrl{ get; set; }
    }
}
