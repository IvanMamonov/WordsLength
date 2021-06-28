using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordsLine = Console.ReadLine();
            var sb = new StringBuilder();

            foreach (char c in wordsLine)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }

            wordsLine = sb.ToString();

            var wordsArr = wordsLine.Split(' ')
                                         .OrderBy(x => x.Length);
            foreach (var w in wordsArr)
            {
                Console.WriteLine(w);
            }
        }
    }
}
