namespace Exeal.LeapYearKata.TDD.Tests
{
    public class LeapYearSpecs
    {
        [Theory]
        [InlineData(1200)]
        [InlineData(1600)]
        [InlineData(2000)]
        public void IsLeapIfIsDivisibleBy400(int value)
        {
            //Arrange
            var year = new Year(value);

            //Act & Assert
            Assert.True(year.IsLeap());
        }

        [Theory]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        public void IsNotLeapIfIsDivisibleBy100ButNoBy400(int value)
        {
            //Arrange
            var year = new Year(value);

            //Act & Assert
            Assert.False(year.IsLeap());
        }

        [Theory]
        [InlineData(1996)]
        [InlineData(1992)]
        [InlineData(1988)]
        public void IsLeapIfIsDivisibleBy4ButNotBy100(int value)
        {
            //Arrange
            var year = new Year(value);

            //Act & Assert
            Assert.True(year.IsLeap());
        }

        [Theory]
        [InlineData(1501)]
        [InlineData(1789)]
        [InlineData(1903)]
        public void IsNotLeapIfIsNotDivisibleBy4(int value)
        {
            //Arrange
            var year = new Year(value);

            //Act & Assert
            Assert.False(year.IsLeap());
        }
    }
}