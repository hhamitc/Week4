using ConstructorExample;

internal class Program
{
    private static void Main(string[] args)
    {

        //Creating a baby object with default constructor

        Bebek baby1 = new Bebek();

        baby1.Name = "Ayşe"; // Setting name and surname.
        baby1.Surname = "Kiraz";
        baby1.BabyInfo();


        Console.WriteLine(new string('-', 33));


        //Creatin another baby object with alternative constructor
        Bebek baby2 = new Bebek("Hakan", "Kaçan");
        baby2.BabyInfo();








        Console.ReadKey();

    }
}