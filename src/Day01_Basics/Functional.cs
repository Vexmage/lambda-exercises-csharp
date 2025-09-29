namespace Day01_Basics;

public static class Functional
{
    /// <summary>
    /// Applies a transformation function to every element in a sequence,
    /// producing a new sequence of results. Equivalent to LINQ's Select.
    /// </summary>
    public static IEnumerable<U> Map<T, U>(IEnumerable<T> source, Func<T, U> f)
    {
        foreach (var item in source)
            yield return f(item);
    }

    /// <summary>
    /// Keeps only the elements of a sequence that satisfy a given predicate.
    /// Equivalent to LINQ's Where.
    /// </summary>
    public static IEnumerable<T> Filter<T>(IEnumerable<T> source, Predicate<T> pred)
    {
        foreach (var item in source)
            if (pred(item)) yield return item;
    }

    /// <summary>
    /// Combines elements of a sequence step by step using a provided function,
    /// starting from a seed value. This version yields intermediate results to
    /// illustrate the accumulation process (e.g. running totals).
    /// </summary>
    public static IEnumerable<T> Reduce<T>(IEnumerable<T> source, Func<T, T, T> combine, T seed)
    {
        var acc = seed;
        foreach (var item in source)
        {
            acc = combine(acc, item);
            yield return acc;
        }
    }

    /// <summary>
    /// Demonstrates a closure issue in C#: lambdas inside a loop capture the same
    /// loop variable, so all functions return the final loop value.
    /// </summary>
    public static List<Func<int>> LoopCapturePitfall()
    {
        var funcs = new List<Func<int>>();
        for (int i = 0; i < 3; i++)
        {
            funcs.Add(() => i);
        }
        return funcs;
    }

    /// <summary>
    /// Fixes the closure problem by copying the loop variable into a new local
    /// variable, ensuring each lambda remembers its own iteration value.
    /// </summary>
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
