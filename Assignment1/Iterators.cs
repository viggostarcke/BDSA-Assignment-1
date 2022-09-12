using System.IO.Compression;

namespace Assignment1;

public static class Iterators
{
    public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
    {
        foreach (var v in items)
        {
            foreach (var _v in v)
            {
                yield return _v;
            }
        }
    }
    
    public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate) => throw new NotImplementedException();
}