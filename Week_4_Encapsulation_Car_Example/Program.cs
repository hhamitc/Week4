using Week_4_Encapsulation_Car_Example;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        Bu örnekte sizlerden bir Araba sınıfı oluşturmanız isteniyor.

        Araba sınıfının özellikleri -> Marka, Model, Renk, Kapı Sayısı

        Özelliklerimizden (Property) Kapı sayısı için kapsülleme işlemi yapmak istiyoruz.

        Eğer bir Araba nesnesi oluşturulduğunda Kapı Sayısı için 2 veya 4 dışında bir değer atanmak isterse konsol ekranında bir uyarı mesajı yayınlayalım ve Kapı Sayısı değerini -1 olarak atayalım.

         */

        Car car1 = new Car("Mazda", "Mx-5", "Red", 2); // Creating new objet from car Class
        car1.DisplayCarInfo();                          //Displaying car info on console.

        Car car2 = new Car("Honda", "Civic Type-R", "Red", 3);// Creating new objet from car Class
        car2.DisplayCarInfo();                            //Displaying car info on console.









        Console.ReadKey();
    }
}
