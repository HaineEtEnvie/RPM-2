using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit //

namespace ClassLibrary1
{
    public class Gryppa
    {
        private readonly string name;
        public string Name { get => name; }

        private readonly string shortname;
        public string Shortname { get => shortname; }
        private readonly string chislo;
        public string Chislo { get => chislo; }
        private readonly string year;
        public string Year { get => year; }
       // private readonly Specialnost specialnost;
        //public Specialnost Specialnost { get => specialnost; }
        //private readonly Sotrydnik sotrydnik;
        //public Sotrydnik Sotrydnik { get => sotrydnik; }
        public Gryppa(string name, string shortname, string chislo, string year) // Specialnost specialnost, Sotrydnik sotrydnik// )
        {
            this.name = name;
            this.shortname = shortname;
            this.chislo = chislo;
            this.year = year;
            //this.specialnost = specialnost;
           // this.sotrydnik=sotrydnik;
        }
    }
}
