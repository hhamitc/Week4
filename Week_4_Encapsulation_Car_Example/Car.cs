namespace Week_4_Encapsulation_Car_Example
{
    public class Car
    {
        // Properties: Brand, Model, Color, Door Count

        public string _brand; // Brand of the car
        public string _modelName; // Model name of the car
        public string _color; // Color of the car
        private int _doorCount; // Door count of the car (private)

        // Constructor to initialize the Car object
        public Car(string brand, string modelName, string color, int doorCount)
        {
            _brand = brand;
            _modelName = modelName;
            _color = color;
            DoorCount = doorCount; // Use the property to set the door count
        }

        // Property for Brand with getter and setter
        public string Brand { get { return _brand; } set { _brand = value; } }

        // Property for ModelName with getter and setter
        public string ModelName { get { return _modelName; } set { _modelName = value; } }

        // Property for Color with getter and setter
        public string Color { get { return _color; } set { _color = value; } }

        // Property for DoorCount with encapsulation
        public int DoorCount
        {
            get { return _doorCount; }
            set
            {
                // Check if the door count is either 2 or 4
                if (value == 2 || value == 4)
                {
                    _doorCount = value;
                }
                else
                {
                    // Print error message and set door count to -1 if invalid
                    Console.WriteLine("Invalid door count value!!");
                    _doorCount = -1;
                }
            }
        }

        // Method to display car information
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Brand: {_brand}\nModel: {_modelName}\nColor: {_color}\nDoor Count: {_doorCount} ");
            Console.WriteLine(new String('-', 33));
        }
    }
}