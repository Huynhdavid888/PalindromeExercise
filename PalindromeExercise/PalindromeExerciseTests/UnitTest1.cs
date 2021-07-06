using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("tenet", true)]
        [InlineData("map", false)]
        [InlineData("honda", false)]
        public void Test1(string word, bool expected)
        {
            var wordsmith = new WordSmith();

            var actual = wordsmith.isAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
