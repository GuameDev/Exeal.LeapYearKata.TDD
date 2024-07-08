
namespace Exeal.LeapYearKata.TDD
{
    public class Year
    {
        public int Value { get; set; }

        public bool IsLeap()
        {
            return this.Value % 400 == 0;
        }
    }
}
