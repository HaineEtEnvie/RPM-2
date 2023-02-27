using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ayditoria
    {
        private readonly string nazvanie;
        public string Nazvanie { get => nazvanie; }

        private readonly Sotrydnik sotrydnik;
        public Sotrydnik Sotrydnik { get => sotrydnik; }

        private readonly string posadmesta;
        public string Posadmesta { get => posadmesta; }

        private readonly string kolvookon;
        public string Kolvookon { get => kolvookon; }

        private readonly Oborudovanie oborudovanie;
        public Oborudovanie Oborudovanie { get => oborudovanie; }

        public Ayditoria(string nazvanie, Sotrydnik sotrydnik, string posadmesta, string kolvookon, Oborudovanie oborudovanie)
        {
            this.nazvanie = nazvanie;
            this.sotrydnik = sotrydnik;
            this.posadmesta = posadmesta;
            this.kolvookon = kolvookon;
            this.oborudovanie = oborudovanie;
        }
    }
}