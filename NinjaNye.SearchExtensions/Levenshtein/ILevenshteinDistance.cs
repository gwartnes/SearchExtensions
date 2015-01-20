namespace NinjaNye.SearchExtensions.Levenshtein
{
    public interface ILevenshteinDistance<out T>
    {
        int Distance { get; }
        T Item { get; }
    }
}