namespace Week4CreatingFirstClass
{
    internal class Person // Okulumdaki sınıftaki kişilerin bilgilerini tutmak için Person sınıfını oluşturdum.
    {

        // Sınıfın Alanlarını oluşturdum.

        public string name;
        public string surname;
        public DateTime birthDate;
        public string status;


        public string Name // İsim alanının property lerinin okuma yazma işlemleri için metot tanımlyorum.
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Surname // Soyisim alanının property lerinin okuma yazma işlemleri için metot tanımlyorum.
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public DateTime BirthDate // Doğum tarihi alanının property lerinin okuma yazma işlemleri için metot tanımlyorum.
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }
        public string Status // Durum alanının property lerinin okuma yazma işlemleri için metot tanımlyorum.
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public void InformationWrite() // Aldığım verileri ekrana yazdırmak için bir metot oluşuturuyorum.
        {
            Console.WriteLine($"Adı: {name} , Soyadı; {surname}, Doğum Tarihi: {birthDate.ToString("dd/mm/yyyy")}; Sınıftaki Konumu: {status}");
        }



    }
}
