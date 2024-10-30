using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Domain.Entities
{
    public class CarFeature
    {
        public int CarFeatureId { get; set; }
        public int CarId { get; set; }
        public Car car { get; set; }
        public int FeaureID { get; set; }
        public Feature feature { get; set; }
        public bool Available {  get; set; }
    }
}
