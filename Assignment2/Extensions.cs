using System.Text.RegularExpressions;

namespace Assignment2;

public static class Extensions
{
    public static bool isSecure(this string Uri) => Uri.ToLower().Contains("https");

    public static int WordCount(this string str) => Regex.Matches(str.Replace("'", ""), "[^\\d\\W]+").Count;
}
