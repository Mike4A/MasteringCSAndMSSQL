﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOps
{
    class Order
    {
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public DateOnly OrderDate { get; set; }
        public decimal Total { get; set; }
    }
}
