﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOps
{
    class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string FullName { get => $"{FirstName} {LastName}"; }
        public int Age { get; set; }
        public string? City { get; set; }
}
}
