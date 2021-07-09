using System;
using System.Collections.Generic;
using program_v1;

namespace program_v3
{
    class Program
    {
        static void Main(string[] args)
        {
            //queuePresentation();
            stackPresentation();
        }
        public static void queuePresentation() {
            Queue<IPerson> kolejka = new Queue<IPerson>();
            kolejka.Enqueue(new Person("Krzysztof", "Stanowski", 31));
            kolejka.Enqueue(new Person("Krzysztof", "Nowak", 27));
            kolejka.Enqueue(new Person("Krzysztof", "dsasdsa", 29));

            IPerson person = kolejka.Dequeue();
            Console.WriteLine($"{person.nazwisko}: {person.wiek}");
            Console.WriteLine("/////////////////////////////////////////////////////////////");
            foreach (var item in kolejka)
            {
                Console.WriteLine($"{item.nazwisko}: {item.wiek}");
            }
        }
        public static void stackPresentation() {
            Stack<IPerson> lista = new Stack<IPerson>();
            lista.Push(new Person("Krzysztof", "Stanowski", 31));
            lista.Push(new Person("Krzysztof", "Nowak", 27));
            lista.Push(new Person("Krzysztof", "Ibisz", 29));

            IPerson person = lista.Pop();

            Console.WriteLine($"{person.nazwisko}: {person.wiek}");
            Console.WriteLine("//////////////////////////");
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.nazwisko}: {item.wiek}");
            }

        }
    }
}
