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

        private readonly int posadmest;
        public int PosadMest { get => posadmest; }

        private readonly int okna;
        public int Okna { get => okna; }
        public Ayditoria(string nazvanie, int posadmest, int okna)
        {
            this.nazvanie = nazvanie;
            this.posadmest = posadmest;
            this.okna = okna;
        }
    }
}