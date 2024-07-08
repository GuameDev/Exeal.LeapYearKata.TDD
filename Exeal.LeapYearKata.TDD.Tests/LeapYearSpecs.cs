namespace Exeal.LeapYearKata.TDD.Tests
{
    public class LeapYearSpecs
    {
        [Fact]
        public void IsLeapIfIsDivisibleBy400()
        {
            //Arrange
            var year = new Year() { Value = 2000 };

            //Act & Assert
            Assert.True(year.IsLeap());
        }

        [Fact]
        public void IsNotLeapIfIsDivisibleBy100ButNoBy400()
        {
            //Arrange
            var year = new Year() { Value = 1900 };

            //Act & Assert
            Assert.False(year.IsLeap());
        }

        [Fact]
        public void IsLeapIfIsDivisibleBy4ButNotBy100()
        {
            //Arrange
            var year = new Year() { Value = 1996 };

            //Act & Assert
            Assert.True(year.IsLeap());
        }
    }
}