using Week_4_Polymorphism_Practice;

internal class Program
{
    public static void Main(string[] args)
    {
        // Create a Triangle object
        BaseGeometricShape triangle = new Triangle();
        triangle.Height = 8;
        triangle.Width = 5;

        // Display the area of the triangle
        triangle.DisplayResult();

        // Separator line
        Console.WriteLine(new string('-', 33));

        // Create a Square object
        BaseGeometricShape square = new Square();
        square.Height = 9;
        square.Width = 10;

        // Display the area of the square
        square.DisplayResult();

        // Separator line
        Console.WriteLine(new string('-', 33));

        // Create a Rectangle object
        BaseGeometricShape rectangle = new Rectangle();
        rectangle.Height = 10;
        rectangle.Width = 5;

        // Display the area of the rectangle
        rectangle.DisplayResult();






        // Wait for a key press to close the console window
        Console.ReadKey();
    }
}