using System.Text;
using Xunit;

namespace Assignment1.Tests;

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
        Assert.Equal(new[] {1,2,3,4}, result);
    }
}