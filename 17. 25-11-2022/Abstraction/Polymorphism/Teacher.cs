﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Teacher : Human
    {
        public byte Experience { get; set; }

        public override void ShowFullData()
        {
            Console.WriteLine($"Fullname: {Name + " " + Surname} Age: {Age} Experience: {Experience} ");
        }
    }
}
