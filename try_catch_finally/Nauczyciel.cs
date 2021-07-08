using System;
using System.Collections.Generic;
using System.Text;

namespace program_v1
{
    public class Nauczyciel : Person, INauczyciel
    {
        public string przedmiot { get; set; }
    }
}
