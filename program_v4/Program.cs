using System;
using System.Collections.Generic;

namespace program_v4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> podium = new Dictionary<int, string>();
            podium.Add(2, "Kacper");
            podium.Add(3, "Jacek");
            podium.Add(1, "Dawid");

            Console.WriteLine("Przed sortowaniem: ");
            foreach (var item in podium)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(" ");
            
            SortedList<int, string> sortedPodium = new SortedList<int, string>(podium);
            Console.WriteLine("Po sortowaniu: ");
            foreach (var item in sortedPodium) {
                Console.WriteLine(item);
            }
        }
    }
}
