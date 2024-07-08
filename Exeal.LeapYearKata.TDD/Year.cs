
namespace Exeal.LeapYearKata.TDD
{
    public class Year
    {
        public int Value { get; set; }

        public Year(int year)
        {
            Value = year;
        }

        public bool IsLeap()
        {
            return (this.Value % 4 == 0 && this.Value % 100 != 0) || (this.Value % 400 == 0);
        }
    }
}
