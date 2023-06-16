namespace Interface;

interface INovel
{
    public List<string> Genres { get; set; }

    public void AddGenre(string genre);
    public void RemoveGene(string genre);
}