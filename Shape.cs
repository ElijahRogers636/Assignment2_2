using System;

namespace Assignment2_2
{
    public abstract class Shape
    {
        //Write a base class: ‘Shape’ and add properties like id, name and color and method like ‘calculate area’.

        public int ID {  get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Shape(int id, string name, string color)
        {
            ID = id;
            Name = name;
            Color = color;
        }

        // Abstract method of CalculateArea to use in inherited classes
        public abstract double CalculateArea();

    }

    // Square class inherits from (Base) Shape class
    public class Square : Shape
    {
        //Inherit square class from shape and add change the calculate area logic.Add property like side of square.
        public double Side { get; set; }

        public Square(int id, string name, string color, double side) : base(id, name, color)
        {
            Side = side;
        }

        public override double CalculateArea()
        {
            return Side * Side;
        }
    }

    // Circle class inherits from (Base) Shape class
    public class Circle : Shape
    {
        //Inherit circle shape from base class and add properties like radius. override calculate area logic for circle.
        public double Radius { get; set; }

        public Circle(int id, string name, string color, double radius) : base(id, name, color)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
