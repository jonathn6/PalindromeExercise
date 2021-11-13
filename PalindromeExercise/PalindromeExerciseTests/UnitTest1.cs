using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("redivider", true)]
        [InlineData("deified", true)]
        [InlineData("civic", true)]
        [InlineData("radar", true)]
        [InlineData("taco cat", true)]
        [InlineData("my gym", true)]
        [InlineData("jonathan", false)]
        [InlineData("TrueCoders", false)]
        public void IsAPalindrome(string word, bool expected)
        {
            //Arrange
            var test = new WordSmith();
            //Act
            var actual = test.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
