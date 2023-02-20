using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ayditoria
    {
        private readonly string name21;
        public string Name21 { get => name21; }

        private readonly string name22;
        public string Name22 { get => name22; }
        private readonly string name23;
        public string Name23 { get => name23; }
        public Ayditoria(string name21, string name22, string name23)
        {
            this.name21 = name21;
            this.name22 = name22;
            this.name23 = name23;
        }
    }
}