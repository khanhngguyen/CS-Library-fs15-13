using System;
namespace Interface;

interface IComic
{
    public List<string> Artists { get; set; }

    public void AddArtist(string artistName);
    public void RemoveArtist(string artistName);
}