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

        private readonly string posadmesta;
        public string Posadmesta { get => posadmesta; }
        private readonly string kolvookon;
        public string Kolvookon { get => kolvookon; }
        public Ayditoria(string nazvanie, string posadmesta, string kolvookon)
        {
            this.nazvanie = nazvanie;
            this.posadmesta = posadmesta;
            this.kolvookon = kolvookon;
        }
    }
}