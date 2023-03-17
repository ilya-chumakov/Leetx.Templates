namespace Leetcode.Templates.Tests;

public class LXT_Tests
{
    [Theory]
    [InlineData(1, 2)]
    public void TwoSum_Default_OK(int input, int expected)
    {
        var actual = _sut.TwoSum(input);
        Assert.Equal(expected, actual);
    }
}