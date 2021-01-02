using Should;
using Xunit;

namespace LeetCode.Ex58.Test
{
    public class SolutionShould
    {
        [Theory]
        [InlineData("Hello World", 5)]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        public void ShouldReturnCorrectResultWhenSolutionExists(string input,  int expectedResult)
        {
            var solution = new Solution();
            var actualResult = solution.LengthOfLastWord(input);

            actualResult.ShouldEqual(expectedResult);
        }
    }
}
