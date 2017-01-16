using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto
{
    class Student : Person 
    {
        public string sezione { get; set}
        public Student (string name, string cognome, int anni, string codicefiscale, string sezione) : base (name, cognome, anni, codicefiscale)
        {
            this.sezione = sezione;
        }
    }
}
