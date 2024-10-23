using Week_4__Abstraction_Practice;

internal class Program
{
    private static void Main(string[] args)
    {

        //Creaeting class objects
        //And Calling informations.

        SoftwareDeveloper sDev1 = new SoftwareDeveloper("Hamit", "Canpolat");

        sDev1.DisplayPosition();

        ProjectManager pManager1 = new ProjectManager("Hasan", "Çildirmiş");

        pManager1.DisplayPosition();

        Salesman salesman = new Salesman("Türkan", "Mavi");

        salesman.DisplayPosition();





        Console.ReadKey();
    }
}