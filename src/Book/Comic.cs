using System;
using Books;
using Interface;

class Comic : Book, IComic
{    
    public List<string> Artists { get; set; }

    public Comic(string title, string author, int year, bool canBorrow = true) : base(title, author, year)
    {
        Title = title;
        Author = author;
        PublicationYear = year;
        CanBorrow = canBorrow;
        Artists = new List<string>();
    }

    public void AddArtist(string artistName)
    {
        var existed = Artists.Find(a => a == artistName);
        if (existed == null)
        {
            Artists.Add(artistName);
        }
        else return;
    }
    public void RemoveArtist(string artistName)
    {
        var existed = Artists.Find(a => a == artistName);
        if (existed == null) throw new ArgumentException("Can not find artist name");
        else Artists.Remove(existed);
    }
    public string GetAllArtits()
    {
        if (Artists.Count() == 0) return $"The comic book {this.Title} does not have any artits yet";
        else
        {
            string text = "Artists:";
            foreach (string item in Artists)
            {
                text = text + " " + item + ",";
            }
            return text.Remove(text.Length - 1, 1);
        }
    }
    public override void PrintInfo()
    {

    }
}