using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {

        static void Main(string[] args)
        {
            Func<string, string> CheckName;
            CheckName = CheckUserName;
            // Ete anuny "Banned" che apa name-y stanum e ayd arjeqy , hakarak depqum - null
            string name = CheckName(Console.ReadLine());

            Console.ReadKey();

        }
        static string CheckUserName(string name)
        {
            if (name.ToLower() == "jack" || name.ToLower() == "steven" || name.ToLower() == "mathew")
            {
                Console.WriteLine("You are Banned!");
                return null;
            }
            else
            {
                Console.WriteLine($"Welcome {name}");
                return name;
            }
        }
    }
}
