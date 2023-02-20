using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Discyplina
    {
        private readonly string name1;
        public string Name1 { get => name1; }

        private readonly string shortname;
        public string Shortname { get => shortname; }

        public Discyplina(string name1, string shortname)
        {
            this.name1 = name1;
            this.shortname = shortname;

        }
    }
}
