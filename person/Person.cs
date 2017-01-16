using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto
{
    class Person
    {
        public string name { get; set}
        public string cognome { get; set}
        private int _anni;
        public int anni
        {
            set
            {
                if (value < 0) value = 1;
                _anni = value;
            }
            get { return _anni}
        }
        private string _codicefiscale;
        public string codicefiscale { set; get { return name + cognome + anni} };

        public Person(string name, string cognome, int anni, string codicefiscale)
        {
            this.name = name;

            this.cognome = cognome;

            this.anni = anni;

            this.codicefiscale = codicefiscale;

            describe();
        }
        public string describe()
        {
            string output = "Nome: " + name + "Cognome: " + cognome + "anni: " + anni + "codice fiscale: " + codicefiscale;
            return output;
        }


    }
}



