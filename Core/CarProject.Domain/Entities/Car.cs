﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Domain.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public string Model {  get; set; }
        public string CoverImageUrl { get; set; }
        public int Km { get; set; }
        public string Tramission { get; set; }
        public byte Lunggage { get; set; }
        public string Fuel {  get; set; }
        public string BigImageUrl {  get; set; }

        public List<CarFeature> CarFeatures { get; set; }
        public List<CarDescription> CarDescriptions { get; set; }


    }
}
