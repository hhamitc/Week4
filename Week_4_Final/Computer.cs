namespace Week_4_Final
{
    public class Computer : BaseMachine
    {
        public string bluetooth;
        public int usbPortCount;
        public int UsbPortCount
        {
            get { return usbPortCount; }
            set
            {
                if (value == 2 || value == 4)
                {
                    usbPortCount = value;
                }
                else
                {
                    Console.WriteLine("\nHatalı Giriş. Port Sayısı -1 olarak ayarlandı.\n");
                    usbPortCount = -1;
                }
            }

        }
        public string Bluetooth
        {
            get { return bluetooth; }
            set
            {
                if (value == "Var" || value == "Yok")
                {
                    bluetooth = value;
                }
                else
                {
                    Console.WriteLine("\nHatalı Giriş. Bluetooth Yok olarak ayarlandı.\n");
                    bluetooth = "Yok";
                }
            }
        }


        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"{DeviceType} Usb Port Sayısı: {UsbPortCount} ");
            Console.WriteLine($"{DeviceType} Bluetoot Durumu: {Bluetooth} ");
            Console.WriteLine($"{DeviceType} başarıyla oluşturuldu. ");

        }

        public Computer(string serialNumber, string productName, string description, string operatingSystem, int usbPortCount, string bluetooth) : base(serialNumber, productName, description, operatingSystem)
        {
            DeviceType = "Bilgisayar";
            UsbPortCount = usbPortCount;
            Bluetooth = bluetooth;
        }
        //public Computer()
        //{
        //    DeviceType = "Computer";
        //    ProduceDate = DateTime.Now;
        //}

    }
}
