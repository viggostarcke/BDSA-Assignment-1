namespace Assignment1.Tests;

using System.Text;
using Xunit;
using FluentAssertions;

public class IteratorsTests
{
    [Fact]
    public void Flatten_should_return_1_2_3_4_from_1_2_array_and_3_4_array()
    {
        //arrange
        int[] testArray1 = { 1, 2 };
        int[] testArray2 = { 3, 4 };
        List<int[]> testList = new List<int[]>();
        testList.Add(testArray1);
        testList.Add(testArray2);

        //act
        var result = Iterators.Flatten(testList);

        //assert
        Assert.Equal(new[] { 1,2,3,4 }, result);
        result.Should().BeEquivalentTo(new[] { 1,2,3,4 });
    }

    [Fact]
    public void Filter_should_return_2_4_from_1_2_3_4_array() 
    {
        //arrange
        Predicate<int> even = Even;
        bool Even(int i) => i % 2 == 0;
        int[] testArray = { 1, 2, 3, 4 };

        //act
        var result = Iterators.Filter(testArray, Even);

        //assert
        Assert.Equal(new[] { 2, 4 }, result);
        result.Should().BeEquivalentTo(new[] { 2, 4 });

    }
}