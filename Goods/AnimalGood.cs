﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods
{
    public class AnimalGood : IGood
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
