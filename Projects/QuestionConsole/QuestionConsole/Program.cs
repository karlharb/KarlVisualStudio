using System.Text.RegularExpressions;
using System;

namespace QuestionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "<tt>some</tt><b>html</b>";
            var pattern =  @"<\w?>(\w*?)<\/\w?>";

            var match = Regex.Match(input, pattern);


            var x = match.Groups[1].Value;

            Console.WriteLine(x);

        }
    }
}
