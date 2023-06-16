namespace Interface;

interface IResearchPaper
{
    public int[] Pages { get; set; }

    public int[] PrintPages(int start, int end);
}