namespace Week_4_Inheritance
{
    // Abstract base class representing a person
    public abstract class BaseKisi
    {
        // Properties for first name and last name
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // Nested class representing a student, inheriting from BaseKisi
        public class Ogrenci : BaseKisi
        {
            // Property for student number
            public int OgrenciNo { get; set; }

            // Method to display student information
            public void OgrenciBilgileri()
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
            public void OgretmenBilgileri()
            {
                Console.WriteLine($"Öğretmen Ad-Soyad: {Ad} {Soyad}, Maaş: {Maas}");
            }
        }
    }
}