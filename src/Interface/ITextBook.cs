namespace Interface;

interface ITextBook
{
    public int[] Pages { get; set; }

    public int[] PrintPages(int start, int end);
}