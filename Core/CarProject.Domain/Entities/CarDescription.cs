using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Domain.Entities
{
    public class CarDescription
    {
        public int CarDescriptionId { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int CarDetails { get; set; }
    }
}
