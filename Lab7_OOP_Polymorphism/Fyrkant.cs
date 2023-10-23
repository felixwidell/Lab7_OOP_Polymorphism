using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_OOP_Polymorphism
{
    internal class Fyrkant : Geometri
    {
        public double Sida {  get; set; }

        public Fyrkant() 
        {
            Sida = 3;
        }

        public override double Area()
        {
            return Sida * Sida;
        }
    }
}
