using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_OOP_Polymorphism
{
    internal class Parallellogram : Geometri
    {
        public double Length { get; set; }
        public double InternalWidth { get; set; }

        public Parallellogram()
        {
            Length = 7;
            InternalWidth = 5;
        }

        public override double Area()
        {
            return Length * InternalWidth;
        }
    }
}
