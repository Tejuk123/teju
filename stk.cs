using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new List<string> { "<name>", "AMv", "Fel" };
            foreach(var n in v)
            {
                Console.WriteLine($"Hello{n.ToUpper()}!");
            }
            Console.WriteLine();
            v.Add("tej");
            v.Remove("Fel");
            foreach (var n in v)
            {
                Console.WriteLine($"Hello{n.ToUpper()}!");
            }
            Console.WriteLine(v.Count);

            Console.ReadLine();
        }
    }
}
