namespace Week_4_Final
{
    public class Phone : BaseMachine
    {
        #region Telefon Sınıfı için gerekli ek field ve propertylerin oluşuturulması
        public string trLicensed;
        public string TRLicensed
        {
            get { return trLicensed; }
            set
            {
                if (value == "evet" || value == "hayir")
                {
                    trLicensed = value;
                }
                else
                {
                    Console.WriteLine("\nHatalı Giriş. Lisans Durumu Hayır olarak ayarlandı.\n");
                    trLicensed = "hayir";
                }
            }
        }
        #endregion



        #region Display info metotuna telefon için override yapımı
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"{DeviceType} TR Lisans Durumu: {TRLicensed} ");
            Console.WriteLine($"{DeviceType} başarıyla oluşturuldu. ");

        }
        #endregion



        #region Telefon sınıfı için property içeren Constructor yazımı
        public Phone(string serialNumber, string productName, string description, string operatingSystem, string trLicensed) : base(serialNumber, productName, description, operatingSystem)
        {
            DeviceType = "Telefon";
            TRLicensed = trLicensed;
        }
        #endregion
    }
}
