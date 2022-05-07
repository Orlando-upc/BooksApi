namespace Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }

        public Book(string title, string author, string publisher, string genre, double price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            Genre = genre;
            Price = price;
        }

        public Book()
        {

        }

        public void Update(string title, string author, string publisher, string genre, double price)
        {
            if (Title.Equals(title) is not true) Title = title;
            if (Author.Equals(author) is not true) Author = author;
            if (Publisher.Equals(publisher) is not true) Publisher = publisher;
            if (Genre.Equals(genre) is not true) Genre = genre;
            if (Price.Equals(price) is not true) Price = price;
        }

    }
}
