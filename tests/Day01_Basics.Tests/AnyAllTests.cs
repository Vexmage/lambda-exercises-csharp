using Day01_Basics;
using FluentAssertions;

namespace Day01_Basics.Tests;

public class AnyAllTests
{
    [Fact]
    public void Any_ReturnsTrue_WhenAtLeastOneMatches()
    {
        var nums = new[] { 1, 2, 3 };
        Functional.Any(nums, x => x > 2).Should().BeTrue();
    }

    [Fact]
    public void Any_ReturnsFalse_WhenNoneMatch()
    {
        var nums = new[] { 1, 2, 3 };
        Functional.Any(nums, x => x > 10).Should().BeFalse();
    }

    [Fact]
    public void All_ReturnsTrue_WhenAllMatch()
    {
        var nums = new[] { 2, 4, 6 };
        Functional.All(nums, x => x % 2 == 0).Should().BeTrue();
    }

    [Fact]
    public void All_ReturnsFalse_WhenAnyFail()
    {
        var nums = new[] { 2, 3, 4 };
        Functional.All(nums, x => x % 2 == 0).Should().BeFalse();
    }

    [Fact]
    public void AnyAll_HandleEmptySequences()
    {
        var empty = Array.Empty<int>();

        // Vacuous truth: All over an empty set is true (no counterexamples)
        Functional.All(empty, _ => false).Should().BeTrue();

        // Any over an empty set is false (no witnesses)
        Functional.Any(empty, _ => true).Should().BeFalse();
    }
}
