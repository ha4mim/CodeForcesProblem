using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Bit__
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine().Trim();
                if (s.Contains("++"))
                {
                    count++;
                }
                else if (s.Contains("--"))
                {
                    count--;
                }
            }
            Console.WriteLine(count);
        }
    }
}
