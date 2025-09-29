using Day01_Basics;
using FluentAssertions;

namespace Day01_Basics.Tests;

public class FilterTests
{
    /// <summary>
    /// Demonstrates using Filter with a lambda that removes odd numbers.
    /// Useful for practicing numeric predicates.
    /// </summary>
    [Fact]
    public void Filter_RemovesOddNumbers()
    {
        var nums = new[] { 1, 2, 3, 4, 5 };
        var evens = Functional.Filter(nums, n => n % 2 == 0);
        evens.Should().Equal(2, 4);
    }

    /// <summary>
    /// Demonstrates filtering out empty or null strings using a lambda.
    /// Shows how to combine null-checks with string conditions.
    /// </summary>
    [Fact]
    public void Filter_RemovesEmptyAndNullStrings()
    {
        var src = new string?[] { "apple", "", null, "banana" };
        var nonEmpty = Functional.Filter(src!, s => !string.IsNullOrEmpty(s));
        nonEmpty.Should().Equal("apple", "banana");
    }

    /// <summary>
    /// Demonstrates filtering items by length property.
    /// Reinforces how lambdas can access object members.
    /// </summary>
    [Fact]
    public void Filter_ByStringLength()
    {
        var words = new[] { "a", "bb", "ccc", "dddd" };
        var longWords = Functional.Filter(words, s => s.Length > 2);
        longWords.Should().Equal("ccc", "dddd");
    }

    /// <summary>
    /// Ensures Filter returns empty when no elements match.
    /// Important edge case to confirm correct behavior.
    /// </summary>
    [Fact]
    public void Filter_NoMatches_ReturnsEmpty()
    {
        var nums = new[] { 1, 3, 5 };
        var evens = Functional.Filter(nums, n => n % 2 == 0);
        evens.Should().BeEmpty();
    }

    /// <summary>
    /// Ensures Filter works correctly with an empty input sequence.
    /// Verifies no exceptions are thrown and result is empty.
    /// </summary>
    [Fact]
    public void Filter_EmptySequence_ReturnsEmpty()
    {
        var empty = Array.Empty<int>();
        Functional.Filter(empty, n => n > 0).Should().BeEmpty();
    }
}
