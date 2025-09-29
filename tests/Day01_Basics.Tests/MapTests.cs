using System.Linq;
using Day01_Basics;
using FluentAssertions;

namespace Day01_Basics.Tests;

public class MapTests
{
    /// <summary>
    /// Demonstrates using Map with a lambda that doubles each number.
    /// Shows how to transform numbers into new values.
    /// </summary>
    [Fact]
    public void Map_DoublesNumbers()
    {
        var src = new[] { 1, 2, 3 };
        var doubled = Functional.Map(src, x => x * 2);
        doubled.Should().Equal(2, 4, 6);
    }

    /// <summary>
    /// Demonstrates projecting numbers into strings with a lambda.
    /// Useful for formatting or labeling output during mapping.
    /// </summary>
    [Fact]
    public void Map_ProjectsToStrings()
    {
        var src = new[] { 1, 2 };
        var labels = Functional.Map(src, n => $"Num:{n}");
        labels.Should().Equal("Num:1", "Num:2");
    }

    /// <summary>
    /// Ensures Map handles empty sequences correctly.
    /// Important to confirm there are no hidden exceptions or unexpected values.
    /// </summary>
    [Fact]
    public void Map_EmptySequence_ReturnsEmpty()
    {
        var empty = Array.Empty<int>();
        Functional.Map(empty, x => x * 2).Should().BeEmpty();
    }

    /// <summary>
    /// Verifies that Map uses deferred execution:
    /// the lambda is not applied until the sequence is actually enumerated.
    /// This mirrors how LINQ works in C#.
    /// </summary>
    [Fact]
    public void Map_IsDeferred_ExecutionOnlyHappensOnEnumeration()
    {
        var evalCount = 0;

        IEnumerable<int> Source()
        {
            foreach (var n in new[] { 1, 2, 3 })
            {
                evalCount++;     // increments only when enumerated
                yield return n;
            }
        }

        var mapped = Functional.Map(Source(), x => x * 10);

        // not enumerated yet
        evalCount.Should().Be(0);

        // force enumeration
        mapped.ToList();

        // now enumerated
        evalCount.Should().Be(3);
    }
}
