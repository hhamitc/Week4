namespace Week_4_Final
{
    public class Phone : BaseMachine
    {
        public string trLicensed;
        public string TRLicensed
        {
            get { return trLicensed; }
            set
            {
                if (value == "Evet" || value == "Hayır")
                {
                    trLicensed = value;
                }
                else
                {
                    Console.WriteLine("\nHatalı Giriş. Lisans Durumu Hayır olarak ayarlandı.\n");
                    trLicensed = "Hayır";
                }
            }
        }



        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"{DeviceType} TR Lisans Durumu: {TRLicensed} ");
            Console.WriteLine($"{DeviceType} başarıyla oluşturuldu. ");

        }

        public Phone(string serialNumber, string productName, string description, string operatingSystem, string trLicensed) : base(serialNumber, productName, description, operatingSystem)
        {
            DeviceType = "Telefon";
            TRLicensed = trLicensed;

        }
    }
}
