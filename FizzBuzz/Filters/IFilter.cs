namespace FizzBuzz.Filters
{
    public interface IFilter
    {
        bool IsMet(int number);
        string Message { get; }
    }
}
