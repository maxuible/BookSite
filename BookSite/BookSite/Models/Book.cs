namespace BookSite.Models
{
    public class Book
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public string Isbn { get; set; }

        public string Type { get; set; }

        public string Url { get; set; }

        public int Status { get; set; }

        public Book() { }

        public Book(string title, string description, string author, string isbn, string type, string url)
        {
            Title = title;
            Description = description;
            Author = author;
            Isbn = isbn;
            Type = type;
            Url = url;
            Status = 0;
        }


    }
}
