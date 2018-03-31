using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface IWriteToFile
    {

        void Write();

    }


    interface ICountOfAngles
    {
        int GetAngles();
    }
    interface ICoords
    {
        int x { get; set; }
        int y { get; set; }
    }
    abstract class Figure
    {
        public string Name { get; set; }
        public double Perimetr{ get; set; }
        public double Area { get; set; }
        public abstract double GetPer();
        public abstract double GetArea();
    }
    class Triangle : Figure, ICountOfAngles, ICoords
    {
        public double Storona{ get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public int GetAngles()
        {
            return 3;
        }

        public override double GetArea()
        {
            Area = Math.Sqrt(3) / 4 * Math.Pow(Storona, 2);
                return Area;
        }

        public override double GetPer()
        {
            Perimetr = Storona * 3;
            return Perimetr;
        }
    }

    class Circle : Figure, ICoords
    {
        public double Radius { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public override double GetArea()
        {
            Area = Math.PI * Math.Pow ( Radius,2);
            return Area;
        }
        public override double GetPer()
        {
            Perimetr = 2 * Math.PI * Radius;
            return Perimetr;
                
        }
    }

    class Sqare : Figure, ICoords, ICountOfAngles
    {
        public int Storona { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public int GetAngles()
        {
            return 4;
        }
        public override double GetArea()
        {
            Area = Math.Pow(Storona, 2);
            return Area;
        }
        public override double GetPer()
        {
            Perimetr = Storona*4;
            return Perimetr;
        }
    }

    class StrWriter : IWriteToFile
    {
        public void Write()
        {
             // srteam writer
        }
    }

    class Program
    {
        static int GetAngles(ICountOfAngles countAngles)
        {
            return countAngles.GetAngles();
        }
        static void PrintCoords(ICoords coords)
        {
            Console.WriteLine($"{coords.x} - {coords.y}");
        }
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.x = 15;
            circle.y = 1;
            PrintCoords(circle);

            IWriteToFile writeToFile = 

        }
    }
}
