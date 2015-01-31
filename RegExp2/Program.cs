using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace RegExp2
{
    public class Program
    {
        public static string pattern2 = "^[0-9]{12}$";
        public static string pattern = "^[0-9]{12}$";
            
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(MyMatch(pattern2,text));
        }

        public static string MyMatch(string pattern, string input)
        {
            Regex r = new Regex(pattern);
           
            if (r.IsMatch(input))
            {
                return "ok";
            }
            else
            {
                return "no";
            }
        }
    }
}
