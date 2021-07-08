using System;
using System.Collections.Generic;
using System.Text;

namespace program_v1
{
    public class uczen : Person, Iuczen
    {
        public string klasa { get; set; }
        public string uczelnia { get; set; } = "WSEI";
        public override string ToString()
        {
            return $"{imie} {nazwisko} {wiek} {uczelnia}";
        }
    }


}
