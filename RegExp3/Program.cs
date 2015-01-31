using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace RegExp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "[a-z]+";
            string text = "test111test";

            Regex r = new Regex(pattern);
            Match m = r.Match(text);
                
            while(m.Success)
            {
                Console.WriteLine(m.Value);
                m = m.NextMatch();
            }


                foreach (Match m2 in r.Matches(text))
                {
                    Console.WriteLine(m2.Value);
                }
            
        }
    }
}
