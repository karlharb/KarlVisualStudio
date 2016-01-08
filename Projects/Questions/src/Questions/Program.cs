using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Questions
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var a = "<tt>some</tt><b>html</b>";
            var pattern = new Regex(@"/<\w?>(\w*?)<\/\w?>/");
            MatchCollection m = pattern.Matches(a);
            System.Console.WriteLine(m);
        }
    }
}
