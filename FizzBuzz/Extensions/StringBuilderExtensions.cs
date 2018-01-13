using System.Text;

namespace FizzBuzz.Extensions
{
    public static class StringBuilderExtensions
    {
        public static bool IsEmpty(this StringBuilder stringBuilder)
        {
            return stringBuilder.Length == 0;
        }
    }
}
