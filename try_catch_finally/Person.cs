using System;
using System.Collections.Generic;
using System.Text;

namespace program_v1
{
    public class Person : IPerson
    {
        public Person()
        {

        }
        public Person(string Imie, string Nazwisko, int Wiek)
        {
           imie = Imie;
           nazwisko = Nazwisko;
           wiek = Wiek;
        }
        private int? _wiek;
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int? wiek
        {
            get
            {
                return _wiek;
            }
            set
            {
                if ((value < 120 && value > 0) || value==null )
                {
                    _wiek = value;
                }
                else
                {
                    throw new Exception("zły wiek");
                }
            }
        }
        public override string ToString()
        {
            return $"{imie} {nazwisko} {wiek}";
        }
    }
}
