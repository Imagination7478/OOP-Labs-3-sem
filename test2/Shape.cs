using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Circle
namespace OOP_test_2
{
    public struct Vector
    {
        public double x, y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y);
        }
    }
    public class Shape
    {
        //Center
        private double x, y;
        private double radius;

        public Shape(double x, double y, double radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        void showCoords() {
            Console.WriteLine($"Center: x = {x}, y = {y}");
        }

        void showRadius() {
            Console.WriteLine($"Radius is x = {radius}");
        }

        public override string ToString()
        {
            return $"(x = {x}, y = {y})";
        }   

        public void move(Vector vector)
        {
            this.x += vector.x;
            this.y += vector.y;
        }

        public double getPer()
        {
            return Math.PI * 2 * radius;
        }

        public double getArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public void showInfo()
        {
            Console.WriteLine(getInfo());
        }

        public string getInfo()
        {
            string centre = $"Centre: x = {x}, y = {y}";
            string rad = $"Radius: {radius}";
            return $"{centre}\n{rad}";
            //return centre + "\n" + rad;
        }
    }
}
