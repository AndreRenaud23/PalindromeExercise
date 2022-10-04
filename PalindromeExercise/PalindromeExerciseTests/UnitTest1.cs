using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("pizza", false)]
        [InlineData("redivider", true)]
        [InlineData("raindeer", false)]
        [InlineData("reviver", true)]

        public void IsAPalindromeTest(string strInput, bool expected)
        {
            //Arrange
            var input = new WordSmith();

            //Act
            var actual = input.IsAPalindrome(strInput);

            //Assert
            Assert.Equal(actual, expected);


        }
    }
}
