using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of names
            List<string> names = new List<string> { "Will R", "Will D", "Ethan T", "Cormac R", "Adam B", "Asthon R", "Ben H", "Tom A", "Henry J"};

            //List of scores
            List<int> score = new List<int> { 40, 36, 47, 24, 42, 35, 37, 31, 28 };

            int n = 0;

            while (n < 9)
            {
                Console.WriteLine(names[n] + " has got a score of " + score[n]);
                Console.WriteLine();
                n++;
            }
            Console.ReadLine();
        }
    }
}
