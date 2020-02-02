using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseAlternatorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var result = CaseAlternatorTask.AlternateCharCases(word);
            foreach (var element in result)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
