using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace RegExp
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "^t(es){2,}t$";
            Regex r = new Regex(pattern);
            string text =  Console.ReadLine();
            if (r.IsMatch(text))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
