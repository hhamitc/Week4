namespace Week_4_Inheritance
{
    // Abstract base class representing a person
    public abstract class BaseKisi
    {
        // Property for first name
        public string Ad { get; set; }

        // Property for last name
        public string Soyad { get; set; }

        // Method to display basic information
        public virtual void BilgiYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }

        // Nested class representing a student, inheriting from BaseKisi
        public class Ogrenci : BaseKisi
        {
            // Property for student number
            public int OgrenciNo { get; set; }

            // Method to display student information
            public override void BilgiYazdir()
            {
                Console.WriteLine($"Öğrenci Ad-Soyad:{Ad} {Soyad}, Öğr.No: {OgrenciNo}");
            }
        }

        // Nested class representing a teacher, inheriting from BaseKisi
        public class Ogretmen : BaseKisi
        {
            // Property for salary
            public int Maas { get; set; }

            // Method to display teacher information
            public override void BilgiYazdir()
            {
                Console.WriteLine($"Öğretmen Ad-Soyad: {Ad} {Soyad}, Maaş: {Maas}");
            }
        }
    }
}
