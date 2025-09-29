using System.Linq;                 // for .Select(...)
using Day01_Basics;
using FluentAssertions;

namespace Day01_Basics.Tests;

public class MapFilterTests
{
    [Fact]
    public void Map_AppliesFunctionToEachElement()
    {
        var src = new[] { 1, 2, 3 };
        var doubled = Functional.Map(src, x => x * 2);
        doubled.Should().Equal(2, 4, 6);
    }

    [Fact]
    public void Filter_RemovesNonMatching()
    {
        var src = new string?[] { "a", "", "b", null };
        var nonEmpty = Functional.Filter(src!, s => !string.IsNullOrEmpty(s));
        nonEmpty.Should().Equal("a", "b");
    }

    [Fact]
    public void Reduce_ShowsIntermediateAccumulators()
    {
        var src = new[] { 1, 2, 3 };
        var sums = Functional.Reduce(src, (a, b) => a + b, 0);
        sums.Should().Equal(1, 3, 6);
    }

    [Fact]
    public void LoopCapturePitfall_ShowsSameFinalValue()
    {
        var funcs = Functional.LoopCapturePitfall();
        funcs.Select(f => f()).Should().OnlyContain(x => x == 3);
    }

    [Fact]
    public void LoopCaptureFixed_CapturesDistinctValues()
    {
        var funcs = Functional.LoopCaptureFixed();
        funcs.Select(f => f()).Should().Equal(0, 1, 2);
    }
}
