// https://docs.google.com/document/d/1qCEMkbMRvvHP361IFDeWgSpHfVRUp6BV67nrsjl3fSw/edit
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Discyplina
    {
        private readonly string name;
        public string Name { get => name; }

        private readonly string shortname;
        public string Shortname { get => shortname; }

        public Discyplina(string name, string shortname)
        {
            this.name = name;
            this.shortname = shortname;
        }
    }
}
