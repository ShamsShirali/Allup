﻿using Allub.Models;

namespace Allub.ViewModels.HomeVMs
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> NewArrivals { get; set; }
        public IEnumerable<Product> BestSeller { get; set; }
        public IEnumerable<Product> Featured { get; set; }
    }
}
