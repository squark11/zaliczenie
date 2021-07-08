using System;
using System.Collections.Generic;
using System.Text;

namespace program_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson dane_osobowe = new Person();
            uczen dane_ucznia = new uczen();
            dane_ucznia.imie = "Kacper";
            dane_ucznia.nazwisko = "Mackowiak";
            

            try
            {
                dane_ucznia.wiek = 21;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine(dane_ucznia);
            }
            foreach (var item in getPeople()) {
                StringBuilder text = new StringBuilder();
                text.Append($"{item.imie} {item.nazwisko} {item.wiek}");
                if(item is INauczyciel n)
                {
                    text.Append($" {n.przedmiot}");
                }
                else if(item is Iuczen u)
                {
                    text.Append($" {u.klasa} {u.uczelnia}");
                }
                Console.WriteLine(text.ToString());
            }
        }

        public static List<IPerson> getPeople()
        {
            List<IPerson> output = new List<IPerson>();
            output.Add(new uczen() { imie = "Dawid", nazwisko = "Król", klasa = "Ii", wiek = 20, uczelnia = "AGH" });
            output.Add(new Nauczyciel() { imie = "Jacek", nazwisko = "Mosakowski", wiek=null, przedmiot = "C#" });
            return output;
        }
    }
}


