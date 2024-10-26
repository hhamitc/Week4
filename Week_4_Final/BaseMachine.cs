namespace Week_4_Final
{
    public abstract class BaseMachine
    {
        #region Property oluşturma
        public string DeviceType { get; protected set; }
        public DateTime ProduceDate { get; protected set; }
        public string SerialNumber { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }
        #endregion


        #region Bilgileri konsola yazdıracak metodu oluşturma
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"------ {DeviceType} ------");
            Console.WriteLine($"{DeviceType} Üretim Tarihi: {ProduceDate} ");
            Console.WriteLine($"{DeviceType} Seri Numarası: {SerialNumber} ");
            Console.WriteLine($"{DeviceType} Açıklama: {Description} ");
            Console.WriteLine($"{DeviceType} İşletim Sistemi: {OperatingSystem} ");
        }
        #endregion


        #region Parametre alan Constructor oluşturma
        protected BaseMachine(string serialNumber, string productName, string description, string operatingSystem)
        {
            SerialNumber = serialNumber;
            ProductName = productName;
            Description = description;
            OperatingSystem = operatingSystem;
            ProduceDate = DateTime.Now;
        }
        #endregion

    }


}
