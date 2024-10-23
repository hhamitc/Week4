namespace Week_4__Abstraction_Practice
{
    public abstract class Employee
    {
        /*Creating the properties, and there is no need to define a
        department since the department information will be automatically
        derived from the class in which it is created.*/

        public string Name { get; set; }
        public string LastName { get; set; }


        //Creating consructor for make data entry mandatory
        public Employee(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        //We are defining our method as abstract so that it can be customized for each department.
        public abstract void DisplayPosition();
    }

    //Derivig department classes based on Employee
    public class SoftwareDeveloper : Employee
    {
        public SoftwareDeveloper(string name, string lastName) : base(name, lastName)
        {
        }

        //Displaying Employee info

        public override void DisplayPosition()
        {
            Console.WriteLine($"{Name} {LastName} working as SoftwareDeveloper.");

        }
    }

    //Derivig department classes based on Employee

    public class ProjectManager : Employee
    {   //Creating constructor for sending base class
        public ProjectManager(string name, string lastName) : base(name, lastName)
        {

        }
        //Displaying Employee info
        public override void DisplayPosition()
        {
            Console.WriteLine($"{Name} {LastName} working as Project Manager.");
        }
    }

    //Derivig department classes based on Employee

    public class Salesman : Employee
    {
        //Creating constructor for sending base class

        public Salesman(string name, string lastName) : base(name, lastName)
        {

        }

        //Displaying Employee info

        public override void DisplayPosition()
        {
            Console.WriteLine($"{Name} {LastName} working as Salesman.");
        }


    }







}

