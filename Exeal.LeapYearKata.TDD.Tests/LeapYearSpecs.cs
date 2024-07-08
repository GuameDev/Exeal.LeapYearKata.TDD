namespace Exeal.LeapYearKata.TDD.Tests
{
    public class LeapYearSpecs
    {
        [Fact]
        public void IsLeapIfIsDivisibleBy400()
        {
            var year = new Year() { Value = 2024 };
            Assert.True(year.IsLeap());
        }
    }
}