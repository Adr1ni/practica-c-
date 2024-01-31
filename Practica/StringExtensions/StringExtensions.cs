
namespace Practica.StringExtensions
{
    public static class StringExtensions
    {
        public static string FirstLetterUpperCase(this string str)
        {
            char firstLetter = char.ToUpper(str[0]);
            string restFrase = str[1..];

            return firstLetter + restFrase;
        }
    }
}
