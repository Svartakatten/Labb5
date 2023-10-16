using System.Reflection.Metadata;

namespace Labb5
{
    internal class Program
    {
        //Main metoden för Programmet
        static void Main(string[] args)
        {
            //Här skapas objekt för dem
            Circle Circle1 = new Circle(5, 6);
            Circle Circle2 = new Circle(6, 6);

            Triangle Triangle1 = new Triangle(5, 5);

            //Här skrivs 
            Console.WriteLine($"Cirkeln som var 5 i radie blir {Circle1.getArea()} och cirkeln som var 6 i radie blir {Circle2.getArea()}");
            Console.WriteLine($"Triangels Area: {Triangle1.getArea()}");
        }
    }
    //Klassen för uträkningen av cirkeln med konstruktorn m.m
    public class Circle
    {
        //Variablarna
        private const double _pi = 3.141f;
        private double _Radius { get; set; }
        private double _Height { get; set; }

        //Konstruktorn som set'er variablarna
        public Circle(int Radius, int Height)
        {
            _Radius = Radius;
            _Height = Height;
        }
        //Här räknar den ut arean av en cirkel
        public double getArea()
        {
            double Result = _Radius * _Radius * _pi;
            return Result;
        }
        //Här räknar den ut omkretsen av cirkeln
        public double getPerimeter()
        {
            double Result2 = (_Radius * 2) * _pi;
            return Result2;
        }
        //Volym om det vore ett klot
        public double getVolume()
        {
            double Result3 = _pi * (_Radius * _Radius) * _Height;
            return Result3;
        }
    }
    //Räkna ut en triangles area
    public class Triangle
    {
        //Variablar
        private double _Height { get; set; }
        private double _Width { get; set; }
        //Konstruktor
        public Triangle(int Height, int Width)
        {
            _Height = Height;
            _Width = Width;
        }
        //Metod för uträkning
        public double getArea()
        {
            double Result = (_Height * _Width) / 2;
            return Result;
        }
    }
}