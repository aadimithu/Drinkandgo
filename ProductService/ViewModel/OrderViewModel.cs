﻿using ProductService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.ViewModel
{
    public class OrderViewModel
    {
        public Order Order { get; set; }
        public ApplicationUser User { get; set; }
    }

}
