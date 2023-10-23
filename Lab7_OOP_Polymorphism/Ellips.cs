using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_OOP_Polymorphism
{
    internal class Ellips : Geometri
    {
        public double MajorRadius { get; set; }
        public double MinorRadius { get; set; }

        public Ellips() 
        {
            MajorRadius = 7;
            MinorRadius = 5;
        }

        public override double Area()
        {
            return MajorRadius * MinorRadius * Math.PI;
        }
    }
}
