using System;

namespace program_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(mnozenie(5, 3, 2));
            decimal a = 3;
            Console.WriteLine(kwadrat(ref a)); 
            Console.WriteLine(a);
        }
       // params - tworzenie tablicy z wartości, przesyłanie parametrów przez wartość
        public static decimal? mnozenie(params decimal[] wartosci) { 
            decimal output = 1;
            if (wartosci.Length <= 0) {
                return null;
            }
            foreach (var item in wartosci)
            {
                output *= item;
                
            }
            return output;
        }
        //przesyłanie wartości przez referencję
        public static decimal kwadrat(ref decimal x) {
            return x*=x;
        }
    }
}
