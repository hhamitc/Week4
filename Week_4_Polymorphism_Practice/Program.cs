using Week_4_Polymorphism_Practice;

internal class Program
{
    public static void Main(string[] args)
    {
        // Create a Triangle object
        BaseGeometricShape triangle = new Triangle();
        triangle._height = 8;
        triangle._width = 5;

        // Display the area of the triangle
        triangle.DisplayResult();

        // Separator line
        Console.WriteLine(new string('-', 33));

        // Create a Square object
        BaseGeometricShape square = new Square();
        square._height = 9;
        square._width = 10;

        // Display the area of the square
        square.DisplayResult();

        // Separator line
        Console.WriteLine(new string('-', 33));

        // Create a Rectangle object
        BaseGeometricShape rectangle = new Rectangle();
        rectangle._height = 10;
        rectangle._width = 5;

        // Display the area of the rectangle
        rectangle.DisplayResult();






        // Wait for a key press to close the console window
        Console.ReadKey();
    }
}