// See https://aka.ms/new-console-template for more information
//namespace Demo
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Triangle triangle = new Circle();
//            Console.WriteLine(triangle.GetShape());
//        }
//    }

//    public class Triangle
//    {
//        public virtual string GetShape()
//        {
//            return "Triangle";
//        }
//    }

//    public class Circle : Triangle
//    {
//        public override string GetShape()
//        {
//            return "Circle";
//        }
//    }
//}

/* To correct above implementation, we need to refactor this code by introducing interface with method called GetShape. */

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle();
            Console.WriteLine(shape.GetShape());
            shape = new Triangle();
            Console.WriteLine(shape.GetShape());
        }
    }

    public abstract class Shape
    {
        public abstract string GetShape();
    }

    public class Triangle : Shape
    {
        public override string GetShape()
        {
            return "Triangle";
        }
    }

    public class Circle : Triangle
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }
}