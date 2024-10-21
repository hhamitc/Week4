using Week_4_PatikaKutuphane;

internal class Program
{
    private static void Main(string[] args)
    {
        // Creating a book object with default counstructor 
        Kitap kitap1 = new Kitap();

        kitap1.BookName = "Adı Aylin";
        kitap1.AuthorName = "Ayşe;";
        kitap1.AuthorSurname = "Kulin;";
        kitap1.PageCount = 398;
        kitap1.Publisher = "Remzi Kitabevi";


        kitap1.BookInfo();//Printing book informations to console.


        // Creating a book object with alternative counstructor 


        Kitap kitap2 = new Kitap("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");

        kitap2.BookInfo();


        // Creating a book object with default counstructor wtitout any information
        Kitap kitap3 = new Kitap();
        kitap3.BookInfo();





        // Class bir nesnenin yapısını ve davranışlarını tanımlayan bir şablondur. Bu örnekte Kitap adında bir sınıf oluşturduk. Bu sınıf, kitap nesnelerini temsil ediyor ve kitapla ilgili özellikleri (property) ve davranışları (metotlar) içeriyor.

        //Property, sınıfın içindeki verileri temsil eder. Kitap sınıfı içinde, kitabın adı, yazarı, sayfa sayısı, yayınevi ve kayıt tarihi gibi bilgileri tutan property'ler tanımlandı. Bu özelliklere dışarıdan erişilebilir ve değiştirilebilir.

        //New anahtar kelimesi, bir sınıftan yeni bir nesne yaratmak için kullanılır. Bu işlemle sınıfın bir örneği (instance) oluşturulur. Örneğin, kitap1 ve kitap2 isimli iki ayrı kitap nesnesi oluşturduk.

        //Constructor, bir sınıftan yeni bir nesne oluşturulurken ilk olarak çalışan özel bir metottur. Constructor, nesnenin başlangıç durumunu ayarlamaya yarar. Örnekte, iki tür constructor kullandık: biri parametre almayan (default constructor), diğeri ise kitapla ilgili bilgileri parametre olarak alıp, nesne yaratıldığında bu bilgileri property'lere atayan bir constructor'dır.






        Console.ReadKey();
    }
}