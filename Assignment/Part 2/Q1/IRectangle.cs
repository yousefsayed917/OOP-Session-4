﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal interface IRectangle :IShape
    {
        public double Width { get; set; }
        public double Length { get; set; }
    }
}
