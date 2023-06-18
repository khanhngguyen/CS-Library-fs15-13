namespace Books;
using Interface;

class Novel : Book, INovel
{
    public List<string> Genres { get; set; }

    public Novel(string title, string author, int year, bool canBorrow = true) : base(title, author, year)
    {
        Title = title;
        Author = author;
        PublicationYear = year;
        CanBorrow = canBorrow;
        Genres = new List<string>();
    }

    public void AddGenre(string genre)
    {
        var existed = Genres.Find(g => g == genre);
        if (existed == null) Genres.Add(genre);
        else return;
    }
    public void RemoveGene(string genre)
    {
        var existed = Genres.Find(g => g == genre);
        if (existed == null) throw new ArgumentException("Can not find genre");
        else Genres.Remove(genre);
    }
    public string GetAllGenres()
    {
        if (Genres.Count() == 0) return $"The novel named {this.Title} does not have any genre yet";
        else 
        {
            string text = "Genres:";
            foreach (string item in Genres)
            {
                text = text + " " + item + ",";
            }
            return text.Remove(text.Length - 1, 1);
        }
    }
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine(this.GetAllGenres());
    }
}