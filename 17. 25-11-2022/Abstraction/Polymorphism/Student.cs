﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Student : Human
    {
        public double Point { get; set; }

        public override void ShowFullData()
        {
            Console.WriteLine($"Fullname: {Name + " " + Surname} Age: {Age} Point: {Point} ");
        }
    }
}
