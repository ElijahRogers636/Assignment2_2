
namespace Assignment2_2
{
    internal class Program
    {
        //Take the input from user to select circle or square and display the calculated area. no hard coded values!
        static void Main(string[] args)
        {
            /* TestCode 
            Circle circle1 = new Circle(123, "Circle", "Blue", 8.5);
            Console.WriteLine("Circle One");
            Console.WriteLine("ID: " + circle1.ID);
            Console.WriteLine("Name: " + circle1.Name);
            Console.WriteLine("Color: " + circle1.Color);
            Console.WriteLine("Area: " + circle1.CalculateArea());
            Console.WriteLine();

            Square square1 = new Square(321, "Square", "Green", 5);
            Console.WriteLine("Square One");
            Console.WriteLine("ID: " + square1.ID);
            Console.WriteLine("Name: " + square1.Name);
            Console.WriteLine("Color: " + square1.Color);
            Console.WriteLine("Area: " + square1.CalculateArea());
            Console.WriteLine();
            */


            Console.WriteLine("Create a shape by typing it's corresponding number: \n(1)Circle or (2)Square");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            Console.WriteLine("Choose an ID for your shape");
            Console.Write("Choice: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose a Name for your shape");
            Console.Write("Choice: ");
            string name = Console.ReadLine();

            Console.WriteLine("Choose a Color for your shape");
            Console.Write("Choice: ");
            string color = Console.ReadLine();

            printShapeInfo(choice, id, name, color);
            
        }
        
        static void printShapeInfo(string choice, int id, string name, string color)
        {
            string shapeChoice = "";
            // Use a switch statement for scalability
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Choose a Radius for your shape");
                    Console.Write("Choice: ");                   
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Circle circle = new Circle(id, name, color, radius);
                    Console.WriteLine("Shape: Circle");
                    Console.WriteLine("ID: " + circle.ID);
                    Console.WriteLine("Name: " + circle.Name);
                    Console.WriteLine("Color: " + circle.Color);
                    Console.WriteLine("Area: " + circle.CalculateArea());
                    Console.WriteLine();
                    break;
                case "2":
                    Console.WriteLine("Choose a Side Length for your shape");
                    Console.Write("Choice: ");
                    double sideLen = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Square square = new Square(id, name, color, sideLen);
                    Console.WriteLine("Shape: Square");
                    Console.WriteLine("ID: " + square.ID);
                    Console.WriteLine("Name: " + square.Name);
                    Console.WriteLine("Color: " + square.Color);
                    Console.WriteLine("Area: " + square.CalculateArea());
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Shape could not be created as (" + choice + ") is not an acceptable option");
                    break;
            }
        }
    }
}
