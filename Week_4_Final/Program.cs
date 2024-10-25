using Week_4_Final;

public class Program
{
    public static void Main(string[] args)
    {
    Begin:
        string serialNumber = string.Empty;
        string productName = string.Empty;
        string description = string.Empty;
        string operatingSystem = string.Empty;
        string model = string.Empty;
        string trLicensed = string.Empty;
        int usbPortCount = 0;
        string bluetooth = string.Empty;

        Console.Clear();
        Console.WriteLine("Telefon Üretmek için 1'e , Bilgisayar üretmek için 2'ye basın");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
        {
            Console.WriteLine();
            Console.WriteLine("Telefon Bilgilerini Giriniz:");


        }
        else if (keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.NumPad2)
        {
            Console.WriteLine();

            Console.WriteLine("Bilgisayar Bilgilerini Giriniz:");

        }
        else
        {
            goto Begin;
        }


        Console.Write("Seri Numarası: ");
        serialNumber = Console.ReadLine();
        Console.Write("Ürün Adı: ");
        productName = Console.ReadLine();
        Console.Write("Açıklama: ");
        description = Console.ReadLine();
        Console.Write("İşletim Sistemi: ");
        operatingSystem = Console.ReadLine();


        if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
        {

            Console.Write("Tr Lisanlı Mı (Evet/Hayıt): ");
            trLicensed = Console.ReadLine();
            Phone phone = new Phone(serialNumber, productName, description, operatingSystem, trLicensed);

            // Bilgileri ekrana yazdır
            phone.DisplayInfo();

        }
        else if (keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.NumPad2)

            Console.Write("USB Port Sayısı (2 veya 4): ");
        usbPortCount = int.Parse(Console.ReadLine());
        Console.Write("Bluetooth (Var/Yok): ");
        bluetooth = Console.ReadLine();

        // Computer nesnesini oluştur
        Computer computer = new Computer(serialNumber, productName, description, operatingSystem, usbPortCount, bluetooth);

        // Bilgileri ekrana yazdır
        computer.DisplayInfo();






        Console.WriteLine("Yeni bir ürün oluşturmak için E' ye basabilriniz. Aksi halde çıkış yapılacaktır.");
        ConsoleKeyInfo reUseKey = Console.ReadKey();
        if (reUseKey.Key == ConsoleKey.E)
            goto Begin;

        else return;

        Console.ReadKey();
    }
}