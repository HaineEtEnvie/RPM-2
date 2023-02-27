using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Podrazdelenie
    {
        private readonly string nazvanie;
        public string Nazvanie { get => nazvanie; }

        private readonly Sotrydnik sotrydnik;
        public Sotrydnik Sotrydnik { get => sotrydnik; }
        private readonly Organizacia organizacia;
        public Organizacia Organizacia { get => organizacia; }
        public Podrazdelenie(string nazvanie,Sotrydnik sotrydnik,Organizacia organizacia)
        {
            this.nazvanie = nazvanie;
            this.sotrydnik= sotrydnik;
            this.organizacia= organizacia;
        }
    }


}
