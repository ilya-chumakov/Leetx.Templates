namespace Leetcode.Templates.Tests;

public class LXF_Tests
{
    [Fact]
    public void TwoSum_Default_OK()
    {
        var input = 1;
        var expected = 2;
        var actual = _sut.TwoSum(input);
        Assert.Equal(expected, actual);
    }
}