namespace Week_4_Polymorphism_Practice
{
    // Abstract base class for geometric shapes
    public abstract class BaseGeometricShape
    {
        // Properties for height and width
        public int _height { get; set; }
        public int _width { get; set; }

        // Virtual method to calculate the area
        public virtual double CalculateArea()
        {
            return _height * _width;
        }

        // Virtual method to display the result
        public virtual void DisplayResult()
        {
            Console.WriteLine("Sonuç: " + CalculateArea());
        }
    }

    // Derived class for Triangle
    public class Triangle : BaseGeometricShape
    {
        // Override method to calculate the area of a triangle
        public override double CalculateArea()
        {
            return (_height * _width) / 2;
        }

        // Override method to display the result for a triangle
        public override void DisplayResult()
        {
            Console.WriteLine("Üçgenin Alanı= " + CalculateArea());
        }
    }

    // Derived class for Rectangle
    public class Rectangle : BaseGeometricShape
    {
        // Override method to display the result for a rectangle
        public override void DisplayResult()
        {
            Console.WriteLine("Dikdörtgenin Alanı= " + CalculateArea());
        }
    }

    // Derived class for Square
    public class Square : BaseGeometricShape
    {
        // Override method to display the result for a square
        public override void DisplayResult()
        {
            Console.WriteLine("Karenin Alanı= " + CalculateArea());
        }
    }
}