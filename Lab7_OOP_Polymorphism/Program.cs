namespace Lab7_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri Cirkel = new Cirkel();
            Geometri Ellips = new Ellips();
            Geometri Fyrkant = new Fyrkant();
            Geometri Parallellogram = new Parallellogram();
            Geometri Rektangel = new Rektangel();

            Console.WriteLine("Cirkel area: " + Cirkel.Area().ToString("#.00"));
            Console.WriteLine("Ellips area: " + Ellips.Area().ToString("#.00"));
            Console.WriteLine("Fyrkant area: " + Fyrkant.Area().ToString("#.00"));
            Console.WriteLine("Parallellogram area: " + Parallellogram.Area().ToString("#.00"));
            Console.WriteLine("Rektangel area: " + Rektangel.Area().ToString("#.00"));
        }
    }
}