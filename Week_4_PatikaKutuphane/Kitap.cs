namespace Week_4_PatikaKutuphane
{
    internal class Kitap
    {



        // Creating my fields 
        public string _bookName;
        public string _authorName;
        public string _authorSurname;
        public int _pageCount;
        public string _publisher;
        public DateTime _recordDate;


        //Setting my properties of my fields
        public string BookName { get { return _bookName; } set { _bookName = value; } }
        public string AuthorName { get { return _authorName; } set { _authorName = value; } }
        public string AuthorSurname { get { return _authorSurname; } set { _authorSurname = value; } }
        public int PageCount { get { return _pageCount; } set { _pageCount = value; } }
        public string Publisher { get { return _publisher; } set { _publisher = value; } }

        //Creating default constructor method
        public Kitap()
        {
            _bookName = "Girilmedi. ";
            _authorName = "Girilmedi";
            _authorSurname = "Girilmedi";
            _pageCount = 0;
            _publisher = "Girilmedi";
            _recordDate = DateTime.Now;
        }

        //Creating alternative constructor method
        public Kitap(string bookName, string authorName, string authorSurname, int pageCount, string publisher)
        {
            _bookName = bookName;
            _authorName = authorName;
            _authorSurname = authorSurname;
            _pageCount = pageCount;
            _publisher = publisher;
            _recordDate = DateTime.Now;
        }

        //Giving output message for book info
        public void BookInfo()
        {
            Console.WriteLine($"Kitap Adı: {_bookName}\nYazar Adı- Soyadı: {_authorName} {_authorName}\nSayfa Sayısı: {_pageCount}\nYayın Evi: {_publisher}\nKayıt tarihi: {_recordDate}");
            Console.WriteLine(new String('-', 33));
        }










    }
}
