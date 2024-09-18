using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise2
{
    internal class Program
    {
        abstract class Shape //creates a abstract parent shape class
        {
            public abstract double CalculateArea(); //abstract method to calculate an area of a shape
        }

        class Circle : Shape //circle class that is the child of the shape class
        {
            public double Radius { get; set; } //declares an encapsulated double variable named Radius
            public Circle(double radius) //Cricle constructor with a double variable input
            {
                Radius = radius; //sets radius input equal to Radius variable
            }

            public override double CalculateArea() //CalculateArea methoid that overrides the parent method
            {
                double area = Radius * Radius * Math.PI; //declares area variable and sets it equal to the equation
                                                         //of finding a circles area
                return area; //returns area variable
            }
        }

        class Rectangle : Shape //rectangle class that is the child of the shape class
        {
            public double Width { get; set; } //declares an encapsulated double variable named Width
            public double Height { get; set; } //declares an encapsulated double variable named Height
            public Rectangle(double width, double height) //Cricle constructor with two double variable inputs
            {
                Width = width; //sets width input equal to Width variable
                Height = height; //sets height input equal to Height variable
            }

            public override double CalculateArea() //CalculateArea methoid that overrides the parent method
            {
                double area = Width * Height; //declares area variable and sets it equal to the equation
                                              //of finding a rectangles area
                return area; //returns area variable
            }
        }

        class Triangle : Shape //triangle class that is the child of the shape class
        {
            public double Base { get; set; } //declares an encapsulated double variable named Base
            public double Height { get; set; } //declares an encapsulated double variable named Height
            public Triangle(double basee, double height) //Triangle constructor with two double variable inputs
            {
                Base = basee; //sets basee (extra e because it wouldnt let me do base) input equal to Base variable
                Height = height; //sets height input equal to Height variable
            }

            public override double CalculateArea() //CalculateArea methoid that overrides the parent method
            {
                double area = Height * Base * 0.5; //declares area variable and sets it equal to the equation
                                                   //of finding a triangles area
                return area; //returns area variable
            }
        }

        static void Main(string[] args) //main method
        {
            Shape[] shapes = {new Circle(2), new Rectangle(2,4), new Triangle(2,4)}; //creates a Shape class array with children class objects

            foreach (Shape shape in shapes) //loop to loop through each object in the shapes array
            {
                Console.WriteLine($"The shapes area is: {shape.CalculateArea()}"); //displays the area of the shape
            }

            Console.Read(); //allows user to read the program
        }
    }
}
