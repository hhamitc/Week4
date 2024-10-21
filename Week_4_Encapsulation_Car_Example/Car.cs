namespace Week_4_Encapsulation_Car_Example
{
    public class Car
    {
        //Marka, Model, Renk, Kapı Sayısı

        public string _brand;
        public string _modelName;
        public string _color;
        private int _doorCount;

        public Car(string brand, string modelName, string color, int doorCount)
        {
            _brand = brand;
            _modelName = modelName;
            _color = color;
            DoorCount = doorCount;
        }

        public string Brand { get { return _brand; } set { _brand = value; } }

        public string ModelName { get { return _modelName; } set { _modelName = value; } }

        public string Color { get { return _color; } set { _color = value; } }

        public int DoorCount
        {
            get { return _doorCount; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _doorCount = value;
                }
                else
                {
                    Console.WriteLine("Hatalı kapı sayısı değeri!!");
                    _doorCount = -1;
                }
            }
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Marka: {_brand}\nModel: {_modelName}\nRenk: {_color}\nKapı Sayısı: {_doorCount} ");
            Console.WriteLine(new String('-', 33));

        }








    }
}