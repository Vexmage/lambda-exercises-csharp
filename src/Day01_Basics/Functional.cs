namespace Day01_Basics;

public static class Functional
{
    public static IEnumerable<U> Map<T, U>(IEnumerable<T> source, Func<T, U> f)
    {
        foreach (var item in source)
            yield return f(item);
    }

    public static IEnumerable<T> Filter<T>(IEnumerable<T> source, Predicate<T> pred)
    {
        foreach (var item in source)
            if (pred(item)) yield return item;
    }

    // Educational: yields intermediate totals (1, then 3, then 6)
    public static IEnumerable<T> Reduce<T>(IEnumerable<T> source, Func<T, T, T> combine, T seed)
    {
        var acc = seed;
        foreach (var item in source)
        {
            acc = combine(acc, item);
            yield return acc;
        }
    }

    // Loop-capture pitfall
    public static List<Func<int>> LoopCapturePitfall()
    {
        var funcs = new List<Func<int>>();
        for (int i = 0; i < 3; i++)
        {
            funcs.Add(() => i);
        }
        return funcs;
    }

    // Fixed capture using a local copy
    public static List<Func<int>> LoopCaptureFixed()
    {
        var funcs = new List<Func<int>>();
        for (int i = 0; i < 3; i++)
        {
            var copy = i;
            funcs.Add(() => copy);
        }
        return funcs;
    }
}
