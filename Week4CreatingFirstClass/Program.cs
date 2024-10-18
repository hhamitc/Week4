using Week4CreatingFirstClass;

internal class Program
{
    private static void Main(string[] args)
    {

        Person person1 = new Person();

        // Person sınıfımın nesnelerini oluşturuyorum.

        person1.name = "Hamit";
        person1.surname = "Canpolat";
        person1.birthDate = new DateTime(1991, 08, 23);
        person1.status = "Öğrenci";


        Person person2 = new Person();
        person2.name = "Atakan";
        person2.Surname = "Gürdal";
        person2.birthDate = new DateTime(1996, 05, 02);
        person2.status = "Öğrenci";

        Person person3 = new Person();
        person3.name = "Gizem";
        person3.Surname = "Güneş";
        person3.birthDate = new DateTime(1996, 10, 16);
        person3.status = "Öğrenci";

        Person person4 = new Person();
        person4.name = "Yiğit";
        person4.surname = "Hacıefendioğlu";
        person4.birthDate = new DateTime(1985, 07, 28);
        person4.status = "Öğretmen";


        // Nesneleri metotla çağırıp ekrana yazdırıyorum.

        person1.InformationWrite();
        person2.InformationWrite();
        person3.InformationWrite();
        person4.InformationWrite();




        Console.ReadKey();
    }
}