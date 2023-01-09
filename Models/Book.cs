namespace FirstAPI.Models
{
    public class Book
    {
        public int Id { get; }
        public string Title { get; set; } = "Unnamed Book";
        public Author Author { get; set; } = null!;


        public Book() {
        }

        public Book(string title, Author author)
        {
            Title = title;
            Author = author;
        }
    }
}
