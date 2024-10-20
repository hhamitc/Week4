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
