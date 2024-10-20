# Patika+ 4. Hafta Constructor Metod Uygulama Örneğidir

Aşağıdaki soruya cevap verir.

Bu örnekte sizlerden bir **Bebek** sınıfı tanımlamanız isteniyor.

### Bebek sınıfının property'leri:
- Doğum Tarihi
- Ad
- Soyad

### Bebek sınıfı için 2 adet constructor tanımlayınız:
1. **Default Constructor**: Parametre almayan bir metot.
2. **Alternatif Constructor**: Ad ve Soyad parametrelerini alarak, newleme işlemi sırasında değerleri property'lere atayan constructor.

Her iki constructor içerisinde de ortak olarak bebek nesnesi oluşturulduğunda konsol ekranında bir **"Ingaaaa"** yazısı görülsün ve **Doğum Tarihi** o anki tarih olarak atansın.

Tanımlama sonrasında her iki constructor ile de birer bebek nesnesi oluşturup, bu nesnelerin özelliklerini konsol ekranına yazdırınız.


Uygulanan çözüm de aşağıdaki gibidr;



```
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
```
```
namespace ConstructorExample
{
    internal class Bebek
    {

        //Created my fields
        public string _name;
        public string _surname;
        public DateTime _birthDate;



        //Set my properties for my fileds
        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public DateTime BirthDate { get { return _birthDate; } set { _birthDate = value; } }

        //Creating default constructor method
        public Bebek()
        {
            _birthDate = DateTime.Now;
            FirstCry();
        }

        //Creating alternative constructor method
        public Bebek(string name, string surname)
        {
            _name = name;
            _surname = surname;
            _birthDate = DateTime.Now;
            FirstCry();

        }

        //Giving output for baby information
        public void BabyInfo()
        {
            Console.WriteLine($"Bebek dünyaya geldi!! \nBebeğin Bilgileri: ");
            Console.WriteLine($"Adı: {_name}, \nSoyadı: {_surname}, \nDoğum Zamanı: {_birthDate}");
        }

        //Baby crying
        public void FirstCry()
        {
            Console.WriteLine("Ingaaaa!!!");
        }

    }
}

```
