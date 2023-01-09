namespace FirstAPI.Models
{
    public class Author
    {
        public long Id { get; }
        public string Name { get; set; } = "No Name";
        public string Surname { get; set; } = "No Surname";

        public Author(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
