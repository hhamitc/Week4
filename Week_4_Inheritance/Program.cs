using static Week_4_Inheritance.BaseKisi;

internal class Program
{
    public static void Main(string[] args)
    {
        // Creating an instance of the Ogretmen class
        Ogretmen ogretmen = new Ogretmen();
        //ogretmen.Ad = "Yiğit"; // Setting the first name
        ogretmen.Soyad = "Hacıefendioğlu"; // Setting the last name
        ogretmen.Maas = 75000; // Setting the salary

        // Displaying teacher information
        ogretmen.BilgiYazdir();
        Console.WriteLine(new string('-', 33)); // Printing a separator

        // Creating an instance of the Ogrenci class
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Ad = "Hamit"; // Setting the first name
        ogrenci.Soyad = "Canpolat"; // Setting the last name
        ogrenci.OgrenciNo = 144144144; // Setting the student number

        // Displaying student information
        ogrenci.BilgiYazdir();












        Console.ReadKey();
    }
}